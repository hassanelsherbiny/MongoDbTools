using MongoConnection.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using System.Diagnostics;
using TypeBuilderNamespace;
using System.Web.Script.Serialization;
using System.IO;
using MongoDB.Bson.Serialization;
using System.Windows.Forms;
using MongoDbTools;
using System.IO.Compression;

namespace MongoConnection.Logic
{
    public static class MongoGeneralLogic
    {
        //public List<>

        #region Server Connection

        public static bool TryToConnectToServer(MDTServer server)
        {
            bool result = false;
            MongoClient client = new MongoClient(server.ConnectionString);
            MongoServer mongoserver = client.GetServer();
            try
            {
                mongoserver.Connect();
                result = true;
            }
            catch
            {
            }

            //MongoDatabase database = server.GetDatabase("RUF");
            return result;
        }



        public static List<string> GetServerDataBases(MDTServer server)
        {
            List<string> result = new List<string>();
            MongoClient client = new MongoClient(server.ConnectionString);
            MongoServer mongoserver = client.GetServer();
            try
            {
                result = mongoserver.GetDatabaseNames().ToList();
            }
            catch
            {
            }

            //MongoDatabase database = server.GetDatabase("RUF");
            return result;
        }


        #endregion

        #region Database
        public static void CreateDataBase(string serverConnectionString, string DbName)
        {
            MongoClient client = new MongoClient(serverConnectionString);
            string msg;
            MongoServer mongoserver = client.GetServer();
            if (mongoserver.DatabaseExists(DbName))
                throw new Exception("Database Already Exist");
            else if (!mongoserver.IsDatabaseNameValid(DbName, out msg))
                throw new Exception("Database Name Not Valid.\n" + msg);
            else
            {
                var database = client.GetDatabase(DbName);
                var collection = database.GetCollection<BsonDocument>("PlaceHolder");
                collection.InsertOne(new BsonDocument("PlaceHolder", "This Is Just Place Holder For Your Db"));
            }


        }
        public static List<string> GetDatabaseCollections(string serverConnectionString, string DbName)
        {
            List<string> result = new List<string>();
            MongoClient client = new MongoClient(serverConnectionString);
            MongoServer mongoserver = client.GetServer();
            try
            {
                result = mongoserver.GetDatabase(DbName).GetCollectionNames().ToList();
            }
            catch
            {
            }
            return result;
        }


        #endregion

        #region Collections
        public static object LoadCollection(string serverConnectionString, string dbName, string collectionName)
        {
            object result = null;
            MongoClient client = new MongoClient(serverConnectionString);
            MongoServer mongoserver = client.GetServer();
            var DyType = new { Name = "", Id = 0 };
            //result = mongoserver.GetDatabase(dbName).GetCollection(collectionName).AsQueryable().ToList();
            var filter = FilterDefinition<BsonDocument>.Empty;
            var collection = client.GetDatabase(dbName).GetCollection<BsonDocument>(collectionName);
            var Names = collection.Find(_ => true).ToList().Select(x => x.Names).FirstOrDefault().ToList();
            var ty = MyTypeBuilder.CompileResultType(Names);
            result = client.GetDatabase(dbName).GetCollection<object>(collectionName).Find(_ => true).ToList();
            var json = new JavaScriptSerializer().Serialize(result);
            File.WriteAllText("D:/jso.json", json);


            try
            {
            }
            catch
            {
            }
            return result;
        }

        private static void InsertSingleDocuments(List<BsonDocument> dataCollectionDict, IMongoCollection<BsonDocument> collection
      , string Log)
        {
            foreach (var data in dataCollectionDict)
            {
                try
                {
                    collection.InsertOne(data);
                }
                catch (Exception ex)
                {
                    //supose first key is the main key
                    var Key = data.Names.ToList()[0];
                    //var filter = Builders<BsonDocument>.Filter.Eq(s =>s.Elements.FirstOrDefault(), Key);
                    //var result =  collection.ReplaceOne(filter, data);
                    Log += ex;

                }
            }
        }
        public static void DropDataBase(string serverConnectionString, string dbName)
        {
            MongoClient client = new MongoClient(serverConnectionString);
            client.DropDatabase(dbName);
        }
        public static void Import(string DbName, List<string> JsonFiles, string serverConnectionString)
        {
            foreach (var jsonFilePath in JsonFiles)
            {
                var JsonFile = File.ReadAllText(jsonFilePath);
                string CollectionName = Path.GetFileNameWithoutExtension(jsonFilePath);
                MongoClient client = new MongoClient(serverConnectionString);
                var collection = client.GetDatabase(DbName).GetCollection<object>(CollectionName);
                var bsonDocument = BsonSerializer.Deserialize<List<object>>(JsonFile);
                collection.InsertMany(bsonDocument);
            }


        }

        public static List<object> GetCollecyion(string serverConnectionString, string DbName, string CollectionName)
        {
            MongoClient client = new MongoClient(serverConnectionString);

            return client.GetDatabase(DbName).GetCollection<object>(CollectionName).Find(x => true).ToList();

        }
        #endregion


        #region Local Host

        public static void StopLocalHost()
        {
            var localHostProcess = Process.GetProcessesByName("mongod");
            foreach (var p in localHostProcess)
            {
                p.Kill();
            }
        }

        public static void StartLocalHost(string MongoInstallationPath, string DataFilesPath)
        {
            ProcessStartInfo pinfo = new ProcessStartInfo();
            pinfo.Arguments = "--dbpath " + DataFilesPath;
            pinfo.FileName = MongoInstallationPath;
            pinfo.CreateNoWindow = false;
            pinfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(pinfo);
        }
        public static void RestatLocalHost(string MongoInstallationPath, string DataFilesPath)
        {
            StopLocalHost();
            StartLocalHost(MongoInstallationPath, DataFilesPath);
        }
        #endregion

        #region Export & Import

        public static void ExportToJson(string serverConnectionString, string dbName,
           string SaveFolder, List<string> Collections, string MongoPath, bool FormatJson,
           out string log)
        {
            string Log = "";
            MongoClient client = new MongoClient(serverConnectionString);
            //Prepare Directory
            if (!Directory.Exists(SaveFolder))
                Directory.CreateDirectory(SaveFolder);
            //Create Temp Dir to export to
            var TempDir = CreateTempDir();
            Parallel.ForEach(Collections, collectionName =>
            {

                try
                {
                    string outputfile = Path.Combine(TempDir, collectionName + ".json");
                    string command = string.Format("-d {0} -c {1} --jsonArray {3} --out {2} ", dbName, collectionName, outputfile, FormatJson ? "--pretty" : "");
                    RuMongoProcess("mongoexport.exe", MongoPath, command);

                    //Move Output from temp
                    File.Move(outputfile, Path.Combine(SaveFolder, Path.GetFileName(outputfile)));

                }
                catch (Exception ex)
                {
                    Log += dbName + "\n" + ex;
                }
            });


            try
            {
                Directory.Delete(TempDir, true);
            }
            catch
            {
            }
            log = Log;
        }

        private static void RuMongoProcess(string porgram, string MongoPath, string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(MongoPath, porgram);
            startInfo.Arguments = command;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            Process exportProcess = new Process();
            exportProcess.StartInfo = startInfo;
            exportProcess.Start();
            exportProcess.WaitForExit();
        }

        public static void ExportToDump(string serverConnectionString, string dbName,
         string OutPutFile, List<string> Collections, string MongoPath,
         out string log)
        {
            string Log = "";
            MongoClient client = new MongoClient(serverConnectionString);
            //Prepare Directory 
            //Create Temp Dir to export to
            var TempDir = CreateTempDir();

            string command = string.Format("-d {0} -o {1} ", dbName, TempDir);
            RuMongoProcess("mongodump", MongoPath, command);
            string TempOutPutFile = TempDir + ".MDT";
            ZipFile.CreateFromDirectory(Path.Combine(TempDir, dbName), TempOutPutFile);
            File.Move(TempOutPutFile, OutPutFile);

            try
            {
                Directory.Delete(TempDir, true);
            }
            catch
            {
            }
            log = Log;
        }

        public static void ImportFromDump(string ServerConnectionString, string DbName, string FilePath, bool DropIfExist)
        {
            //Unzip File To Temp
            var TempPath = CreateTempDir();
            ZipFile.ExtractToDirectory(FilePath, TempPath);
            var MongoPath = GetMongoPath();
            //Drop If Exist TODO
            string command = string.Format("-d {0} {1}", DbName, TempPath);
            RuMongoProcess("mongorestore.exe", MongoPath, command);
        }

        private static string GetMongoPath()
        {
            //TODO Make Dynamic
            return @"C:\Program Files\MongoDB\Server\3.4\bin\";
        }

        private static string CreateTempDir()
        {
            string TempDirPath = @"C:\MongoDbTools";
            Random r = new Random();
            while (Directory.Exists(TempDirPath))
            {
                TempDirPath += r.Next(30).ToString();
            }
            Directory.CreateDirectory(TempDirPath);
            return TempDirPath;
        }

        public static void ExportToDb(string serverConnectionString, string dbName,
        List<string> Collections,
           string Server2ConnectionString, string Db2Name, out string log)
        {
            string Log = "";
            MongoClient client = new MongoClient(serverConnectionString);
            MongoClient client2 = new MongoClient(Server2ConnectionString);
            MongoServer mongoserver = client.GetServer();

            if (!mongoserver.IsDatabaseNameValid(Db2Name, out Log))
                throw new Exception("Database Name Not Valid.\n" + Log);
            else if (!mongoserver.DatabaseExists(Db2Name))
            {
                var database = client.GetDatabase(Db2Name);
            }
            var listOfTasks = new List<Task>();
            foreach (var collectionName in Collections)
            {
                var result = client.GetDatabase(dbName).GetCollection<BsonDocument>(collectionName).Find(_ => true).ToList();
                var collection = client2.GetDatabase(Db2Name).GetCollection<BsonDocument>(collectionName);

                try
                {

                    listOfTasks.Add(Task.Factory.StartNew(() =>
                    {
                        //foreach (var item in result)
                        //{
                        //    try
                        //    {
                        //        collection.InsertOne(item);
                        //    }
                        //    catch (MongoWriteException ex)
                        //    {
                        //        //collection.FindOneAndReplace(x=>x.FirstOrDefault(t=>t.Value==item.Values["Id"],)
                        //    }

                        //}
                    }));
                    //
                    //collection.UpdateMany(result, collection.Find(_ => true).ToList()); 
                    collection.InsertMany(result, new InsertManyOptions() { BypassDocumentValidation = true });

                }
                catch (Exception ex)
                {
                    Log += dbName + "\n" + ex;
                    InsertSingleDocuments(result, collection, Log);

                }
            }
            Task.WaitAll(listOfTasks.ToArray());
            log = Log;
        }
        #endregion
    }
}

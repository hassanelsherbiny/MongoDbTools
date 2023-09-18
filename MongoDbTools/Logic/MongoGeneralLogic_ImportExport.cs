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
using System.Web.Script.Serialization;
using System.IO;
using MongoDB.Bson.Serialization;
using System.Windows.Forms;
using MongoDbTools;
using System.IO.Compression;
using System.Data;

namespace MongoConnection.Logic
{
    public static partial class MongoGeneralLogic
    {
        #region Import
        public static string ImportFromDump(MDTServer server, string DbName, string FilePath, bool DropIfExist,

             out TimeSpan Time)
        {
            var watch = new Stopwatch();
            watch.Start();
            //Unzip File To Temp
            string Log = "";
            var TempPath = CreateTempDir();
            ZipFile.ExtractToDirectory(FilePath, TempPath);
            if (DropIfExist)
            {
                DropDataBase(server.ConnectionString, DbName);
            }
            string command = string.Format("-d {0} {1} --host \"{2}:{3}\"", DbName, TempPath, server.Server, server.Port);
            Log += RuMongoProcess("mongorestore.exe", command);
            watch.Stop();
            Time = watch.Elapsed;
            return Log;
        }
        public static string ImportFromJson(MDTServer server, string DbName, List<string> Files, bool DropIfExist,

           out TimeSpan Time)
        {
            var watch = new Stopwatch();
            watch.Start();
            string Log = "";
            foreach (var FilePath in Files)
            {
                var CollectionName = Path.GetFileNameWithoutExtension(FilePath);
                Log += ImportFromJson(server, DbName, FilePath, CollectionName, DeleteFile: true, DropIfExist: DropIfExist);
            }

            watch.Stop();
            Time = watch.Elapsed;
            return Log;
        }

        public static string ImportFromJson(MDTServer server, string DbName, string JsonFilePath, string TargetCollectionName, bool DeleteFile, bool DropIfExist)
        {
            string Log = "";
            if (DropIfExist)
                DropCollection(server.ConnectionString, DbName, TargetCollectionName);

            string command = $"--db {DbName} --collection {TargetCollectionName} \"{JsonFilePath}\" --host \"{ server.Server }:{ server.Port}\"";
            Log += RuMongoProcess("mongoimport.exe", command);
            if (DeleteFile)
                File.Delete(JsonFilePath);
            return Log;
        }


        #endregion

        #region Export
        public static string ExportToJson(string serverConnectionString, string dbName,
               string SaveFolder, List<string> Collections, bool FormatJson, bool JsonArray,
               out string log, out TimeSpan Time, bool OnlyAtTemp = false)
        {
            MongoClient client = new MongoClient(serverConnectionString);
            //Prepare Directory
            if (!Directory.Exists(SaveFolder) && !string.IsNullOrEmpty(SaveFolder))
                Directory.CreateDirectory(SaveFolder);
            //Create Temp Dir to export to
            var TempDir = CreateTempDir();
            var watch = new Stopwatch();
            watch.Start();
            List<string> Logs = new List<string>();
            Parallel.ForEach(Collections, collectionName =>
            {
                try
                {
                    string outputfile = Path.Combine(TempDir, collectionName + ".json");
                    string command = string.Format("-d {0} -c {1} {4} {3} --out {2} ", dbName, collectionName, outputfile, FormatJson ? "--pretty" : "", JsonArray ? "--jsonArray" : "");
                    Logs.Add(RuMongoProcess("mongoexport.exe", command));
                    if (!OnlyAtTemp)
                    {
                        //Move Output from temp
                        File.Move(outputfile, Path.Combine(SaveFolder, Path.GetFileName(outputfile)));
                    }
                }
                catch (Exception ex)
                {
                    Logs.Add(dbName + "\n" + ex);
                }
            });
            if (!OnlyAtTemp)

            {
                try
                {
                    Directory.Delete(TempDir, true);
                }
                catch
                {
                }
            }
            log = string.Join(Environment.NewLine, Logs);
            watch.Stop();
            Time = watch.Elapsed;
            return TempDir;
        }
        public static void ExportToDump(MDTServer server, string dbName,
 string OutPutFile, List<string> Collections,
 out string log, out TimeSpan Time)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            string Log = "";
            //Prepare Directory 
            //Create Temp Dir to export to
            var TempDir = CreateTempDir();

            string command = string.Format("-d {0} -o {1} --host \"{2}:{3}\"", dbName, TempDir, server.Server, server.Port);
            Log += RuMongoProcess("mongodump", command);
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
            stopwatch.Stop();
            Time = stopwatch.Elapsed;
            log = Log;
        }

        #endregion


        private static string RuMongoProcess(string porgram, string command)
        {
            var MongoPath = GetMongoPath();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(MongoPath, porgram);
            startInfo.Arguments = command;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;

            startInfo.RedirectStandardError = true;

            startInfo.CreateNoWindow = true;

            Process exportProcess = new Process();
            exportProcess.StartInfo = startInfo;
            exportProcess.Start();
            exportProcess.WaitForExit(30000);
            string output = "";
            // string output2 = exportProcess.StandardOutput.ReadToEnd();

            output = exportProcess.StandardError.ReadToEnd();//Mongo Process Writes To error not output

            return output;
        }



        /// <summary>
        /// Get Mongo installation Path
        /// </summary>
        /// <returns></returns>
        private static string GetMongoPath()
        {
            var MongoPath = @"C:\Program Files\MongoDB\Server\";
            if (Directory.Exists(MongoPath))
            {
                var firstMongoVersion = Directory.GetDirectories(MongoPath).FirstOrDefault();
                MongoPath = Path.Combine(firstMongoVersion, "bin");
            }
            else
            {
                MessageBox.Show("Please Select Mongo Installation Path");
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    MongoPath = fbd.SelectedPath;
                    CorrectMongoPath(MongoPath);
                }
            }
            return MongoPath;
        }


        static string CorrectMongoPath(string MongoPath)
        {

            if (!MongoPath.Contains("bin"))
            {

            }
            return MongoPath;

        }

        private static string CreateTempDir()
        {
            string TempDirPath = @"C:\MongoDbTools\Temp";
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


    }
}

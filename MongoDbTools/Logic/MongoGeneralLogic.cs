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

        public static void DropDataBase(string serverConnectionString, string dbName)
        {
            MongoClient client = new MongoClient(serverConnectionString);
            client.DropDatabase(dbName);
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

    
    }
    public interface baseobject
    {
        string _id { get; set; }
    }
}

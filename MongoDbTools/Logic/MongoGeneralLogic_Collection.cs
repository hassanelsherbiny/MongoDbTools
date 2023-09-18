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

        public static void DropCollection(string serverConnectionString, string dbName, string collectionName)
        {
            MongoClient client = new MongoClient(serverConnectionString);
            client.GetDatabase(dbName).DropCollection(collectionName);
        }

        public static bool DeleteDocument(string serverConnectionString, string dbName, string collectionName, string id)
        {
            MongoClient client = new MongoClient(serverConnectionString);
            var collection = client.GetDatabase(dbName).GetCollection<IDictionary<string, object>>(collectionName);

            var filter = Builders<IDictionary<string, object>>.Filter.Eq(s => s["_id"], id);
            var Deleteone = collection.DeleteOne(filter);
            return Deleteone.DeletedCount > 0;
        }

        public static void UpdateCollection(string id, IDictionary<string, object> item, string ServerConnectionString, string DbName, string collectionName)
        {
            MongoClient client2 = new MongoClient(ServerConnectionString);
            var collection = client2.GetDatabase(DbName).GetCollection<IDictionary<string, object>>(collectionName);
            var filter = Builders<IDictionary<string, object>>.Filter.Eq(s => s["_id"], id);
            collection.ReplaceOne(filter, item);
        }
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
            //var ty = MyTypeBuilder.CompileResultType(Names);
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

        public static void InsertCollections(MDTCollection collectionInfo, List<IDictionary<string, object>> newDocuments)
        {
            var jsonDoc = new JavaScriptSerializer().Serialize(newDocuments);
            var bsonDocs = BsonSerializer.Deserialize<List<BsonDocument>>(jsonDoc);
            MongoClient client = new MongoClient(collectionInfo.Server.ConnectionString);
            var collection = client.GetDatabase(collectionInfo.DatabaseName).GetCollection<BsonDocument>(collectionInfo.CollectionName);
            collection.InsertMany(bsonDocs);
        }
        public static void InsertCollection(MDTCollection collectionInfo, IDictionary<string, object> newDocument)
        {
            var jsonDoc = new JavaScriptSerializer().Serialize(newDocument);
            var bsonDoc = BsonSerializer.Deserialize<BsonDocument>(jsonDoc);
            MongoClient client = new MongoClient(collectionInfo.Server.ConnectionString);
            var collection = client.GetDatabase(collectionInfo.DatabaseName).GetCollection<BsonDocument>(collectionInfo.CollectionName);
            collection.InsertOne(bsonDoc);
        }
        

        public static List<IDictionary<string, object>> GetCollection(string serverConnectionString, string DbName, string CollectionName, out long bytesSize)
        {
            MongoClient client = new MongoClient(serverConnectionString);
            var collection = client.GetDatabase(DbName).GetCollection<BsonDocument>(CollectionName).Find(x => true).ToList();
            bytesSize = collection.Sum(x => x.ToBson().Length);
            return client.GetDatabase(DbName).GetCollection<IDictionary<string, object>>(CollectionName).Find(x => true).ToList();
        }
        public static List<RptData> GetCollectionReport(MDTServer server, string DbName)
        {
            MongoClient client = new MongoClient(server.ConnectionString);
            var lst = new List<RptData>();
            var DbCollections = MongoGeneralLogic.GetDatabaseCollections(server.ConnectionString, DbName);
            foreach (var item in DbCollections)
            {
                var collection = client.GetDatabase(DbName).GetCollection<BsonDocument>(item).Find(x => true).ToList();
                string Size = "";
                float bytesSizeF = collection.Sum(x => x.ToBson().Length);
                if (bytesSizeF < 1000)
                    Size = Math.Round(bytesSizeF, 2) + " Bytes";
                else if (bytesSizeF < 1000 * 1000)
                    Size = Math.Round(bytesSizeF / 1000, 2) + " KB";
                else if (bytesSizeF < 1000 * 1000 * 1000)
                    Size = Math.Round(bytesSizeF / 1000000, 2) + " MB";

                lst.Add(new RptData()
                {
                    CollectionName = item,
                    SizeStr = Size,
                    Size = bytesSizeF,
                    Count = collection.Count
                });
            }

            return lst.OrderByDescending(x => x.Size).ToList();
        }
        public static DataTable ConvertToDataTable(List<IDictionary<string, object>> items)
        {
            DataTable tbl = new DataTable();
            foreach (var item in items)
            {
                //PrepareTableCols(item, tbl);
                var row = tbl.NewRow();
                var keys = item.Keys.ToList();
                foreach (var key in keys)
                {
                    if (!tbl.Columns.Contains(key))
                    {
                        tbl.Columns.Add(key);
                    }
                    row[key] = item[key];
                }

                tbl.Rows.Add(row);
            }
            return tbl;
        }

        /// <summary>
        /// Compare To Collection And Return a list of newly added/updated collections
        /// </summary>
        /// <param name="Collection1">Source Collection</param>
        /// <param name="Collection2">Target Collection To Check For Addition Or Update</param>
        /// <param name="time">Time Operation Took To Done</param>
        /// <returns></returns>
        public static List<CompareResult> CompareCollections(MDTCollection Collection1, MDTCollection Collection2,
            out TimeSpan time)
        {
            List<CompareResult> result = new List<CompareResult>();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var collection1 = GetCollection(Collection1.Server.ConnectionString, Collection1.DatabaseName, Collection1.CollectionName, out long size).ToList();
            var collection2 = GetCollection(Collection2.Server.ConnectionString, Collection2.DatabaseName, Collection2.CollectionName, out long size2).ToList();

            var C1Ids = collection1.Select(x => (x as Dictionary<string, object>)["_id"]).ToList();
            var C2Ids = collection2.Select(x => (x as Dictionary<string, object>)["_id"]).ToList();
            var NewlyAdded = C2Ids.Where(x => !C1Ids.Contains(x)).ToList();
            var NewlyAddedCollections = collection2.Where(x => NewlyAdded.Contains((x as Dictionary<string, object>)["_id"])).Select(x => new CompareResult() { Item = x, CompareType = CompareResultType.New }).ToList();
            var UpdatedCollections = collection2.Where(x => !NewlyAdded.Contains((x as Dictionary<string, object>)["_id"])).ToList();

            foreach (var item2 in UpdatedCollections)
            {
                var Item1 = collection1.FirstOrDefault(x => (x as Dictionary<string, object>)["_id"].Equals(item2["_id"]));
                var Item2json = new JavaScriptSerializer().Serialize(item2);
                var Item1json = new JavaScriptSerializer().Serialize(Item1);
                var IsUpdated = Item1json != Item2json;
                if (IsUpdated)
                {
                    result.Add(new CompareResult() { Item = item2, CompareType = CompareResultType.Updated });
                }
            }
            result.AddRange(NewlyAddedCollections);

            sw.Stop();
            time = sw.Elapsed;

            return result;
        }



    }
}

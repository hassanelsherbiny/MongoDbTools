using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MongoConnection.Data
{
    [Serializable]
    public class MDTMigratorFile
    {
        static string MigratorFilePath = "Migrators";
        public string Id
        {
            get;set;
        }

        public void GenerateId()
        {
            Id = ObjectId.GenerateNewId().ToString();
        }
         
        public string Name { get; set; }
        public MDTServer SourceServer { get; set; }
        public MDTServer DestinationServer { get; set; }
        public string SourceDb { get; set; }
        public string DestinationDb { get; set; }

        public List<string> Collections { get; set; }

        public MDTMigratorFile()
        {
            Collections = new List<string>();
        }

        public static void Save(List<MDTMigratorFile> migrators)
        {
            FileStream fs = new FileStream(MigratorFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, migrators);
            fs.Close();
        }

        public static List<MDTMigratorFile> Load()
        {
          var MigratorFiles = new List<MDTMigratorFile>();

            if (File.Exists(MigratorFilePath))
            {
                FileStream fs = new FileStream(MigratorFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    MigratorFiles = (List<MDTMigratorFile>)bf.Deserialize(fs);
                }
                catch (Exception ex)
                {
                }
                fs.Close();
            }
            if (MigratorFiles == null)
                MigratorFiles = new List<MDTMigratorFile>();
            return MigratorFiles;
        }

    }
}

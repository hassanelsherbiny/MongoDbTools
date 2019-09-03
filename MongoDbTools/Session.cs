using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoConnection.Data;
namespace MongoDbTools
{
    public static class Session
    {
        public static MDTSettings Settings { get; set; }

        public static List<MDTServer> CurrentConnections { get; set; }
        public static List<MDTMigratorFile> Migrators { get; set; }
        static Session()
        {
            Settings = MDTSettings.Load();
            Migrators = MDTMigratorFile.Load(); 
            CurrentConnections = new List<MDTServer>(); 
        }

        internal static void SaveMigrators()
        {
            MDTMigratorFile.Save(Migrators);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
namespace MongoConnection.Data
{
    [Serializable]
    public class MDTSettings
    {
        #region Constants
        //static string SettingFilePath = "Settings.JSON";
        static string SettingFilePath = "Settings.MDT";

        #endregion

        #region Prop

        #region Local Host Service
        public bool StartLocalServiceWithStartUp { get; set; }
        public string LocalHostDataFilesPath { get; set; }
        public string MongoInstallationPath { get; set; }
        public List<MDTServer> Servers { get; set; }

        #endregion

        #endregion
        #region Methods
        //public void Save()
        //{
        //    var json = new JavaScriptSerializer().Serialize(this);
        //    File.WriteAllText(SettingFilePath, json);
        //}

        //public static MDTSettings Load()
        //{
        //    MDTSettings setting = new MDTSettings();
        //    if (File.Exists(SettingFilePath))
        //    {
        //        var json = File.ReadAllText(SettingFilePath); 
        //        setting = (MDTSettings)new JavaScriptSerializer().Deserialize(json, typeof(MDTSettings));
        //    }
        //    if (setting == null)
        //        setting = new MDTSettings();//For Faliures And Empty Json File
        //    return setting;
        //}

        public void Save()
        {
            FileStream fs = new FileStream(SettingFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }

        public static MDTSettings Load()
        {
            MDTSettings setting = new MDTSettings();

            if (File.Exists(SettingFilePath))
            {
                FileStream fs = new FileStream(SettingFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    setting = (MDTSettings)bf.Deserialize(fs);
                }
                catch (Exception)
                {
                }
                fs.Close();
            }
            if (setting == null)
                setting = new MDTSettings();
            return setting;
        }
        #endregion

        private MDTSettings()
        {
            Servers = new List<MDTServer>();
            MongoInstallationPath = @"C:\Program Files\MongoDB\Server\3.4\bin\mongod.exe";
            LocalHostDataFilesPath = @"D:\MongoData";
        }

    }
}

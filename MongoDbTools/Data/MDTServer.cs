using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoConnection.Data
{
    [Serializable]
    public class MDTServer
    {
        /// <summary>
        /// alias Used By User
        /// </summary>
        public string ConnectionAlias { get; set; }

        public string Server { get; set; }

        public int Port { get; set; }

        public bool UseAuth { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string AuthDb { get; set; }
        public string ConnectionString
        {
            get
            {
                string connectionStr = "";
                if (!UseAuth)
                    connectionStr = string.Format("mongodb://{0}:{1}/", Server, Port);

                //Todo Handle Auth Connection String
                return connectionStr;
            }
        }
    }
}

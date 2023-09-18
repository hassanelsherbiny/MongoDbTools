using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoConnection.Data
{
    public class MDTCollection
    {
        public MDTServer Server { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}

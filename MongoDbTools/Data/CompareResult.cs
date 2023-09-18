using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoConnection.Data
{
    public class CompareResult
    {
        public CompareResultType CompareType { get; set; }
        public IDictionary<string, object> Item { get; set; }
    }
    public enum CompareResultType
    {
        New,
        Updated
    }
}

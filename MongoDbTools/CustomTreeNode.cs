using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDbTools
{
    public class ServerTreeNode : TreeNode
    {
        public string ServerConnectionString { get; set; }
    }

    public class DbTreeNode : TreeNode
    {
        public string DbName { get; set; }
        public string ServerConnectionString { get; set; }

        public bool Loaded { get; set; }
    }

    public class CollectionTreeNode : TreeNode
    {
        public string DbName { get; set; }
        public string ServerConnectionString { get; set; }
        public string CollectionName { get; set; }

    }
}

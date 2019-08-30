using MongoConnection.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDbTools
{
    public class ServerTreeNode : BaseTreeNode
    {
        public string ServerConnectionString { get; set; } 
    }

    public class DbTreeNode : BaseTreeNode
    {
        public string DbName { get; set; }
        public string ServerConnectionString { get; set; } 
         
    }

    public class CollectionTreeNode : BaseTreeNode
    {
        public string DbName { get; set; }
        //public string ServerConnectionString { get; set; }
        public string CollectionName { get; set; }
     
    }
    public class BaseTreeNode: TreeNode
    {
        public MDTServer Server { get; set; }
    }
}

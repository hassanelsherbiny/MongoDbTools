using MongoConnection.Data;
using MongoConnection.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDbTools
{
    public partial class FrmCollectionRpt : Form
    {
        public FrmCollectionRpt(MDTServer server, string DbName)
        {
            InitializeComponent();
            label1.Text = server +" - "+ DbName;

            GrvReport.DataSource = MongoGeneralLogic.GetCollectionReport(server, DbName);
        }
    }
    public class RptData
    {
        public string CollectionName { get; set; }
        public string SizeStr { get; set; }
        public float Size { get; set; }

        public int Count { get; set; }
    }
}

using Alex75.JsonViewer.WindowsForm;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace MongoDbTools.UI
{
    public partial class JsonFrm : Form
    {
        JsonTreeView jsonTreeView = new JsonTreeView();
        JObject j = new JObject();
        public JsonFrm(string json)
        {
            InitializeComponent();
            jsonTab.Controls.Add(jsonTreeView);
            txtJson.Text = json;
            j = JObject.Parse(json);
            jsonTreeView.LabelEdit = true;
            jsonTreeView.Dock = DockStyle.Fill;
            //jsonTreeView.AfterSelect += JsonTreeView_AfterSelect; ;
            jsonTreeView.ShowJson(json);
        }
    }
}

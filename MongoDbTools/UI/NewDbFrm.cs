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
    public partial class NewDbFrm : Form
    {
        string ServerConnectionString;
        public NewDbFrm(string ServerConnectionString)
        {
            InitializeComponent();
            this.ServerConnectionString = ServerConnectionString;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtName.Text))
            {
                try
                {
                    MongoGeneralLogic.CreateDataBase(ServerConnectionString,TxtName.Text);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
             
            }
            else
            {
                MessageBox.Show("please Enter Db Name");
            }
        
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

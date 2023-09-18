using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDbTools
{
    public partial class LoadingItem : UserControl
    {
        public LoadingItem(string Title)
        {
            InitializeComponent();
            this.Title = Title;
        }
        public string Progress
        {
            get
            {
                return LblProgress.Text;
            }
            set
            {
                LblProgress.Text = value;
            }
        }
        public string Title
        {
            get
            {
                return LblTask.Text;
            }
            set
            {
                LblTask.Text = value;
            }
        }
    }
}

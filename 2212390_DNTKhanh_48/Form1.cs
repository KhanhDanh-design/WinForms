using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212390_DNTKhanh_48
{
    public partial class fComboBox : Form
    {
        public fComboBox()
        {
            InitializeComponent();
        }

        private void lblComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.lblComboBox.SelectedItem.ToString());
        }

        private void fComboBox_Load(object sender, EventArgs e)
        {
            string[] datas = { "Tiếng Anh", "Tiếng Pháp", "Tiếng Việt" };
            this.lblComboBox.DataSource = datas;
        }
    }
}

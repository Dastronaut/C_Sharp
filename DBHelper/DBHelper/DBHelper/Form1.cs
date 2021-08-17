using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExcute_Click(object sender, EventArgs e)
        {
            string query = txtBox.Text;
            dataGridView1.DataSource = DBHelper.Instance.getRecord(query);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCodeFirst_NonMigration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CSDL db = new CSDL();
            dataGridView1.DataSource = db.SVs.ToList();
        }
    }
}

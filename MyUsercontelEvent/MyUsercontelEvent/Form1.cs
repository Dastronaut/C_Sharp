using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUsercontelEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_TextBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(userControl11.textBox1_Text);
        }

        private void userControl11_Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button is clicked");
        }

        private void userControl12_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(userControl11.combobox_Name);
        }
    }
}

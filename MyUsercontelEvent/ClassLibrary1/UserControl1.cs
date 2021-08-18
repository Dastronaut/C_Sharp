using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler TextBox1_TextChanged;
        public event EventHandler Button1_Click;
        public event EventHandler ComboBox1_SelectedIndexChanged;
        public string textBox1_Text
        {
            get
            {
                return textBox1.Text;
            }
            private set { }
        }
        public string combobox_Name
        {
            get
            {
                return ((CBBItem)comboBox1.SelectedItem).Name;
            }
        }
        public UserControl1()
        {
            InitializeComponent();
            setCBB();
        }
        void setCBB()
        {
            comboBox1.Items.AddRange(new CBBItem[]
            {
                new CBBItem { Name ="Ha Noi"},
                new CBBItem { Name ="Nghe An"},
                new CBBItem { Name ="Hai Phong"},
                new CBBItem { Name ="Da Nang"},
            });
            comboBox1.SelectedIndex = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox1_TextChanged?.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button1_Click?.Invoke(this, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox1_SelectedIndexChanged?.Invoke(this, e);
        }
    }
}

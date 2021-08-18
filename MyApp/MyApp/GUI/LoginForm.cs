using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_BtnLogin_Click(object sender, EventArgs e)
        {
            string us = Login.Text_Username,
                pw = Login.Text_Password;
            if (us == "" || pw == "") return;
            if (us == "datkaka" && pw == "121212")
            {
                MessageBox.Show("Login success");
            }
            else
                MessageBox.Show("Login failed");
        }

        private void Login_Btnreset_Click(object sender, EventArgs e)
        {
            Login.Text_Username = "";
            Login.Text_Password = "";
        }
    }
}

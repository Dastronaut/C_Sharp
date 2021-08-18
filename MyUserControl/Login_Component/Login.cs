using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Component
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        public string Username
        {
            get
            {
                return txtusname.Text;
            }
            set
            {
                txtusname.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return txtpw.Text;
            }
            set
            {
                txtpw.Text = value;
            }
        }
    }
}

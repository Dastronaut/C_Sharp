using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLogin
{
    public partial class LoginComponent: UserControl
    {
        public LoginComponent()
        {
            InitializeComponent();
        }
        public string username
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
        public string password
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
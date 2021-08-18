using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginComponent
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
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

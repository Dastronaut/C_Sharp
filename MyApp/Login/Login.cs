using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : UserControl
    {
        public event EventHandler BtnLogin_Click;
        public event EventHandler Btnreset_Click;
        public string Text_Username
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
        public string Text_Password
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
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            BtnLogin_Click?.Invoke(this, e);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Btnreset_Click?.Invoke(this, e);
        }
    }
}

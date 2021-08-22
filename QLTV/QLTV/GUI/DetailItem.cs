using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class DetailItem : Form
    {
        public delegate void MyDel(string MaSach);
        public MyDel Sender;
        public delegate void refresData();
        public refresData refreshdata;
        public string MS = "";
        private void getMaSach(string s)
        {
            this.MS = s;
        }
        public DetailItem()
        {
            InitializeComponent();
            Sender = new MyDel(getMaSach);
            setCBBID();
        }

        private void setCBBID()
        {
            foreach (TheLoai tl in QLTV_BLL.Instance.getAllTheLoai_BLL())
            {
                cbbtheloai.Items.Add(new CBBItems()
                {
                    Value = tl.ID_TheLoai,
                    Name = tl.TenTheLoai,
                });
            }
            cbbtheloai.SelectedIndex = 0;
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text,
                ten = txtten.Text;
            int nam = Convert.ToInt32(txtnam.Text),
                id = ((CBBItems)cbbtheloai.SelectedItem).Value;
            if (MS == "")
            {
                if (QLTV_BLL.Instance.addSach_BLL(ma, ten, nam, id) != 0)
                {
                    refreshdata();
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                if (QLTV_BLL.Instance.editSach_BLL(ma, ten, nam, id) != 0)
                {
                    refreshdata();
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void DetailItem_Load(object sender, EventArgs e)
        {
            if (MS != "")
            {
                Sach sach = QLTV_BLL.Instance.getSachbyID_BLLL(MS);
                txtma.Text = MS;
                txtma.Enabled = false;
                txtten.Text = sach.TenSach;
                txtnam.Text = sach.NamXB.ToString();
                cbbtheloai.SelectedIndex = sach.ID_TheLoai - 1;
            }
        }
    }
}

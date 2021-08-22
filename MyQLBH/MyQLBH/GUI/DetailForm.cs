using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQLBH
{
    public partial class DetailForm : Form
    {
        public delegate void MyDel(string MaKH);
        public MyDel Sender;
        public delegate void refresData();
        public refresData refreshdata;
        public string MKH = "";
        private void getMKH(string s)
        {
            this.MKH = s;
        }
        public DetailForm()
        {
            InitializeComponent();
            Sender = new MyDel(getMKH);
            setCBBChiNhanh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void setCBBChiNhanh()
        {
            foreach (ChiNhanh cn in QLBH_BLL.Instance.getAllChiNhanh_BLL())
            {
                cbbchinhanh.Items.Add(new CBBItems
                {
                    Value = cn.ID_ChiNhanh,
                    Name = cn.TenChiNhanh,
                });
            }
            cbbchinhanh.SelectedIndex = 0;
        }
        private KhachHang getKH()
        {
            KhachHang kh = new KhachHang();

            return kh;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string makh = txtma.Text,
                tenkh = txtten.Text;
            int tuoi = Convert.ToInt32(txttuoi.Text),
                idchinhanh = ((CBBItems)cbbchinhanh.SelectedItem).Value;
            if (MKH == "")
            {
                if (QLBH_BLL.Instance.addKhachHang_BLL(makh, tenkh, tuoi, idchinhanh) != 0)
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
                if (QLBH_BLL.Instance.editKH_BLLL(makh, tenkh, tuoi, idchinhanh) != 0)
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

        private void DetailForm_Load(object sender, EventArgs e)
        {
            if (MKH != "")
            {
                txtma.Text = MKH;
                KhachHang kh = QLBH_BLL.Instance.getKHbyID_BLL(MKH);
                txtten.Text = kh.TenKH;
                txttuoi.Text = kh.Tuoi.ToString();
                cbbchinhanh.SelectedIndex = kh.ID_ChiNhanh - 1;
                txtma.Enabled = false;
            }
        }
    }
}

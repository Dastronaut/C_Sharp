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
    public partial class ItemDetailForm : Form
    {
        public delegate void MyDel(string MSP);
        public MyDel Sender;
        public delegate void refreshData();
        public refreshData refreshdata;
        string MSP = "";
        private void getMSP(string msp)
        {
            this.MSP = msp;
        }
        public ItemDetailForm()
        {
            InitializeComponent();
            Sender = new MyDel(getMSP);
            setCBBLoaiHang();
        }
        private void setCBBLoaiHang()
        {
            foreach (LoaiHang lh in QLBH_BLL.Instance.getAllLH_BLL())
            {
                cbbloaihang.Items.Add(new CBBItems() { Value = lh.ID_LoaiHang, Name = lh.TenLoaiHang });
            }
            cbbloaihang.SelectedIndex = 0;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (MSP == "")
            {
                string masp = txtmasp.Text,
                tensp = txttensp.Text,
                donvi = txtdonvi.Text;
                double gia = Convert.ToDouble(txtgia.Text);
                int id_loaihang = Convert.ToInt32(((CBBItems)cbbloaihang.SelectedItem).Value);
                if (QLBH_BLL.Instance.addSP_BLL(masp, tensp, donvi, gia, id_loaihang) != 0)
                {
                    MessageBox.Show("Success");
                    refreshdata();
                }
                else
                    MessageBox.Show("Failed");
            }
            else
            {
                string masp = txtmasp.Text,
                    tensp = txttensp.Text,
                    donvi = txtdonvi.Text;
                double gia = Convert.ToDouble(txtgia.Text);
                int id_loaihang = ((CBBItems)cbbloaihang.SelectedItem).Value;
                if (QLBH_BLL.Instance.editSP_DAL(masp, tensp, donvi, gia, id_loaihang) != 0)
                {
                    MessageBox.Show("Success");
                    refreshdata();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void ItemDetailForm_Load(object sender, EventArgs e)
        {
            if (MSP != "")
            {
                SanPham sp = QLBH_BLL.Instance.getSVbyID_BLL(MSP);
                txtmasp.Text = sp.MaSP;
                txttensp.Text = sp.TenSP;
                txtdonvi.Text = sp.DonVi;
                txtgia.Text = sp.Gia.ToString();
                cbbloaihang.SelectedIndex = sp.ID_LoaiHang - 1;
                txtmasp.Enabled = false;
            }
        }
    }
}

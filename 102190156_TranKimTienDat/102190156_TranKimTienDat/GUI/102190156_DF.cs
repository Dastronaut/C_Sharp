using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102190156_TranKimTienDat
{
    public partial class _102190156_DF : Form
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
        public _102190156_DF()
        {
            InitializeComponent();
            Sender = new MyDel(getMSP);
        }

        private void setCBBTP()
        {
            foreach (DC dc in QLKH_BLL.Instance.getAllTP_BLL())
            {
                cbbtp.Items.Add(new CBBItems() { Value = dc.MaTP, Name = dc.TenTP });
            }
            cbbtp.SelectedIndex = 0;
        }

        private void setCBBNCC(List<NCC> nccs)
        {
            cbbncc.Items.Clear();
            foreach (NCC ncc in nccs)
            {
                cbbncc.Items.Add(new CBBItems() { Value = ncc.MaNCC.ToString(), Name = ncc.TenNCC });
            }
            cbbncc.SelectedIndex = 0;
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text,
                ten = txtten.Text;
            float gia = float.Parse(txtgia.Text);
            DateTime ngay = dateTimePicker1.Value;
            int mancc = Convert.ToInt32(((CBBItems)cbbncc.SelectedItem).Value), soluong = Convert.ToInt32(txtsoluong.Text);
            if (MSP == "")
            {
                if (QLKH_BLL.Instance.addSP_BLL(ma, ten, gia, ngay, soluong, mancc) != 0)
                {
                    refreshdata();
                    MessageBox.Show("Success");
                }
                else
                    MessageBox.Show("Failed");
            }
            else
            {
                if (QLKH_BLL.Instance.editSP_BLL(ma, ten, gia, soluong, ngay, mancc) != 0)
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

        private void _102190156_DF_Load(object sender, EventArgs e)
        {
            setCBBTP();
            if (MSP != "")
            {
                SanPham sp = QLKH_BLL.Instance.getSPbyMa_BLL(MSP);
                txtma.Text = sp.MaSP;
                txtten.Text = sp.TenSP;
                txtgia.Text = sp.Gia.ToString();
                txtsoluong.Text = sp.SoLuong.ToString();
                DC tp = QLKH_BLL.Instance.getTPbyMaNCC_BLL(sp.MaNCC);
                for (int i = 0; i < cbbtp.Items.Count; i++)
                {
                    if (((CBBItems)cbbtp.Items[i]).Value == tp.MaTP)
                    {
                        cbbtp.SelectedIndex = i;
                        break;
                    }
                }
                List<NCC> nccs = QLKH_BLL.Instance.getNCCbyMaTP_BLL(((CBBItems)cbbtp.SelectedItem).Value);
                foreach (NCC ncc in nccs)
                {
                    for (int i = 0; i < cbbncc.Items.Count; i++)
                    {
                        if (((CBBItems)cbbncc.Items[i]).Value == sp.MaNCC.ToString())
                        {
                            cbbncc.SelectedIndex = i;
                            break;
                        }
                    }
                    break;
                }
                txtma.Enabled = false;
            }
            else
            {
                List<NCC> nccs = QLKH_BLL.Instance.getNCCbyMaTP_BLL(((CBBItems)cbbtp.SelectedItem).Value);
                setCBBNCC(nccs);
            }

        }

        private void cbbtp_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<NCC> nccs = QLKH_BLL.Instance.getNCCbyMaTP_BLL(((CBBItems)cbbtp.SelectedItem).Value);
            setCBBNCC(nccs);
        }
    }
}

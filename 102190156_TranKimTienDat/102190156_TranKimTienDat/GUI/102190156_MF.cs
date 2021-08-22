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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CSDL db = new CSDL();
            setCBBTP();
            setCBBSort();
            refreshData();
        }

        private void setCBBTP()
        {
            cbbTP.Items.Add(new CBBItems()
            {
                Value = "",
                Name = "All",
            });
            foreach (DC dc in QLKH_BLL.Instance.getAllTP_BLL())
            {
                cbbTP.Items.Add(new CBBItems() { Value = dc.MaTP, Name = dc.TenTP });
            }
            cbbTP.SelectedIndex = 0;
        }

        private void setCBBNCC()
        {
            List<NCC> nccs = QLKH_BLL.Instance.getNCCbyMaTP_BLL(((CBBItems)cbbTP.SelectedItem).Value);
            cbbncc.Items.Clear();
            cbbncc.Items.Add(new CBBItems()
            {
                Value = "",
                Name = "All",
            });
            foreach (NCC ncc in nccs)
            {
                cbbncc.Items.Add(new CBBItems() { Value = ncc.MaNCC.ToString(), Name = ncc.TenNCC });
            }
            cbbncc.SelectedIndex = 0;
        }
        private void setCBBSort()
        {
            cbbsort.Items.AddRange(new CBBItems[]
            {
                new CBBItems() { Value = "1", Name = "Ma SP"},
                new CBBItems() { Value = "2", Name = "Ten SP"},
                new CBBItems() { Value = "3", Name = "Gia"},
            });
            cbbsort.SelectedIndex = 0;
        }

        private void refreshData()
        {
            dataGridView1.DataSource = QLKH_BLL.Instance.getAllSanPham_BLL(txtten.Text, ((CBBItems)cbbncc.SelectedItem).Value, ((CBBItems)cbbTP.SelectedItem).Value);
        }

        private void cbbTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCBBNCC();
            refreshData();
        }

        private void cbbncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            _102190156_DF f2 = new _102190156_DF();
            f2.Sender("");
            f2.refreshdata = refreshData;
            f2.Show();
        }
        private bool isRowSelected()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Khong co dong nao duoc chon");
                return false;
            }
            return true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (!isRowSelected()) return;
            string masp = dataGridView1.CurrentRow.Cells["Ma SP"].Value.ToString();
            _102190156_DF f2 = new _102190156_DF();
            f2.Sender(masp);
            f2.refreshdata = refreshData;
            f2.Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (!isRowSelected()) return;
            string masp = dataGridView1.CurrentRow.Cells["Ma SP"].Value.ToString();
            if (QLKH_BLL.Instance.deleteSP_BLL(masp) != 0)
            {
                refreshData();
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            string prop = ((CBBItems)cbbsort.SelectedItem).Name;
            List<string> listmasp = new List<string>();
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells[0].Value == null) break;
                else listmasp.Add(dr.Cells[0].Value.ToString());
            }
            dataGridView1.DataSource = QLKH_BLL.Instance.sortSP(QLKH_BLL.Instance.getListSP_BLL(listmasp), prop);
        }

        private void btnfefres_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}

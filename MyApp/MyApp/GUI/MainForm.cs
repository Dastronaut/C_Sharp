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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CSDL db = new CSDL();
            setCBBLoaiHang();
            setCBBSort();
            refreshData();
        }

        private void setCBBLoaiHang()
        {
            cbbloaisp.Items.Add(new CBBItems()
            {
                Value = 0,
                Name = "All",
            });
            foreach (LoaiHang lh in QLBH_BLL.Instance.getAllLH_BLL())
            {
                cbbloaisp.Items.Add(new CBBItems() { Value = lh.ID_LoaiHang, Name = lh.TenLoaiHang });
            }
            cbbloaisp.SelectedIndex = 0;
        }
        private void setCBBSort()
        {
            List<string> listprop = QLBH_BLL.Instance.getPropsSP_BLL();
            for (int i = 0; i < listprop.Count - 1; i++)
            {
                cbbsort.Items.Add(new CBBItems()
                {
                    Value = i,
                    Name = listprop[i],
                });
            }
            cbbsort.Items.Add(new CBBItems()
            {
                Value = listprop.Count - 1,
                Name = "LoaiHang",
            });
            cbbsort.SelectedIndex = 0;
        }
        private void refreshData()
        {
            dataGridView1.DataSource = QLBH_BLL.Instance.getAllSP_BLL(txttensp.Text, ((CBBItems)cbbloaisp.SelectedItem).Value);
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void txttensp_TextChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void cbbloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ItemDetailForm f2 = new ItemDetailForm();
            f2.Sender("");
            f2.refreshdata = refreshData;
            f2.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (!isRowSelected()) return;
            string masp = dataGridView1.CurrentRow.Cells["MaSP"].Value.ToString();
            ItemDetailForm f2 = new ItemDetailForm();
            f2.Sender(masp);
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (!isRowSelected()) return;
            string masp = dataGridView1.CurrentRow.Cells["MaSP"].Value.ToString();
            if (QLBH_BLL.Instance.deleteSP_BLL(masp) != 0)
            {
                MessageBox.Show("Success");
                refreshData();
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
                if (dr.Cells["MaSP"].Value == null) break;
                else listmasp.Add(dr.Cells["MaSP"].Value.ToString());
            }
            dataGridView1.DataSource = QLBH_BLL.Instance.sortSP(QLBH_BLL.Instance.getListSP_BLL(listmasp), prop);
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CSDL db = new CSDL();
            setCBBChiNhanh();
            setCBBSort();
            refreshData();
        }
        private void setCBBChiNhanh()
        {
            cbbchinhanh.Items.Add(new CBBItems
            {
                Value = 0,
                Name = "All",
            });
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
        private void setCBBSort()
        {
            int i = 0;
            foreach (string s in QLBH_BLL.Instance.getListProp_BLL())
            {
                cbbsort.Items.Add(new CBBItems { Value = i, Name = s });
                i++;
            }
            cbbsort.SelectedIndex = 0;
        }
        private void refreshData()
        {
            dataGridView1.DataSource = QLBH_BLL.Instance.getAllKH_BLL(txttenkh.Text, ((CBBItems)cbbchinhanh.SelectedItem).Value);
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void txttenkh_TextChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void cbbchinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DetailForm f2 = new DetailForm();
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
            string makh = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
            DetailForm f2 = new DetailForm();
            f2.Sender(makh);
            f2.refreshdata = refreshData;
            f2.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (!isRowSelected()) return;
            string makh = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
            if (QLBH_BLL.Instance.deleteKH_BLL(makh) != 0)
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
            List<string> listmakh = new List<string>();
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells["MaKH"].Value == null) break;
                else listmakh.Add(dgr.Cells["MaKH"].Value.ToString());
            }
            dataGridView1.DataSource = QLBH_BLL.Instance.sortListKH(QLBH_BLL.Instance.getListKHbyMaKH_BLL(listmakh), prop);
        }
    }
}

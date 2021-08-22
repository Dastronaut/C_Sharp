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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CSDL db = new CSDL();
            setCBBID();
            refreshData();
        }
        private void setCBBID()
        {
            cbbtheloai.Items.Add(new CBBItems()
            {
                Value = 0,
                Name = "All",
            });
            foreach (TheLoai tl in QLTV_BLL.Instance.getAllTheLoai_BLL())
            {
                cbbtheloai.Items.Add(new CBBItems
                {
                    Value = tl.ID_TheLoai,
                    Name = tl.TenTheLoai,
                });
            }
            cbbtheloai.SelectedIndex = 0;
        }

        private void refreshData()
        {
            dataGridView1.DataSource = QLTV_BLL.Instance.getAllSach_BLL(txttensahc.Text, ((CBBItems)cbbtheloai.SelectedItem).Value);
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void txttensahc_TextChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void cbbtheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData();
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
        private void btnadd_Click(object sender, EventArgs e)
        {
            DetailItem f2 = new DetailItem();
            f2.Sender("");
            f2.refreshdata = refreshData;
            f2.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (!isRowSelected()) return;
            string makh = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();
            DetailItem f2 = new DetailItem();
            f2.Sender(makh);
            f2.refreshdata = refreshData;
            f2.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (!isRowSelected()) return;
            string makh = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();
            if (QLTV_BLL.Instance.deleteSach_BLL(makh) != 0)
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

        }
    }
}

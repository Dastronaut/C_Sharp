using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQSLV_UsingSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setCBBClass();
            setCBBSort();
            refreshData();
        }

        private void setCBBClass()
        {
            cbbclass.Items.Add(new CBBItem
            {
                Text = "All",
                Value = 0,
            });
            foreach (var i in QLSV_BLL.Instane.getAllLSH_BLL())
            {
                cbbclass.Items.Add(new CBBItem
                {
                    Text = i.NameLop,
                    Value = i.ID_Lop,
                }) ;
            }
            cbbclass.SelectedIndex = 0;
        }

        private void setCBBSort()
        {
            List<string> listprop = QLSV_BLL.Instane.getProps_BLL();
            for (int i = 0; i < listprop.Count - 1; i++)
            {
                cbbsort.Items.Add(new CBBItem
                {
                    Text = listprop[i],
                    Value = i
                });
            }
            cbbsort.Items.Add(new CBBItem
            {
                Text = "NameLop",
                Value = listprop.Count - 1,
            });
            cbbsort.SelectedIndex = 0;
        }

        private void refreshData()
        {
            int id_lop = ((CBBItem)cbbclass.SelectedItem).Value;
            string namesv = txtsearch.Text;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = QLSV_BLL.Instane.getAllSV_BLL(id_lop, namesv);
            dataGridView1.Rows[0].Selected = false;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            cbbclass.SelectedIndex = 0;
            txtsearch.Text = "";
            refreshData();
        }

        private void cbbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string MSSV = "";
            Form2 f2 = new Form2();
            f2.refresh = refreshData;
            f2.Sender(MSSV);
            f2.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (!isRowSelected()) return;
            string MSSV = dataGridView1.CurrentRow.Cells["MSSV"].Value.ToString();
            Form2 f2 = new Form2();
            f2.refresh = refreshData;
            f2.Sender(MSSV);
            f2.Show();
        }
        private bool isRowSelected()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Khong co SV nao duoc chon", "Chu y", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isRowSelected()) return;
            string MSSV = dataGridView1.CurrentRow.Cells["MSSV"].Value.ToString();
            if (QLSV_BLL.Instane.deleteSV_BLL(MSSV) != 0)
                MessageBox.Show("Xoa thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
               MessageBox.Show("Xoa that bai", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshData();
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            string prop = ((CBBItem)cbbsort.SelectedItem).Text;
            List<string> listMSSV = new List<string>();
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells["MSSV"].Value == null) break;
                else listMSSV.Add(dgr.Cells["MSSV"].Value.ToString());
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = 
                QLSV_BLL.Instane.sortSVBy_BLL(QLSV_BLL.Instane.getListSV_BLL(listMSSV), prop);
        }
    }
}

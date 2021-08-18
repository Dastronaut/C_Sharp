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
    public partial class Form2 : Form
    {
        public delegate void MyDel(string MSSV);
        public MyDel Sender;
        public delegate void refreshData();
        public refreshData refresh;
        string MSSV = "";
        private void getMSSV(string _MSSV)
        {
            MSSV = _MSSV;
        }
        public Form2()
        {
            InitializeComponent();
            Sender = new MyDel(getMSSV);
            setCBBClass();
            rbtnmale.Checked = true;
        }
        private void setCBBClass()
        {
            foreach (var i in QLSV_BLL.Instane.getAllLSH_BLL())
            {
                cbbclass.Items.Add(new CBBItem
                {
                    Text = i.NameLop,
                    Value = i.ID_Lop
                });
            }
            cbbclass.SelectedIndex = 0;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            refresh();
            this.Dispose();
        }
        private SV getSV()
        {
            SV sv = new SV();
            sv.MSSV = txtid.Text;
            sv.NameSV = txtname.Text;
            sv.ID_Lop = ((CBBItem)cbbclass.SelectedItem).Value;
            sv.NS = Convert.ToDateTime(dtpicker.Value);
            if (rbtnmale.Checked)
            {
                sv.Gender = true;
            }
            if (rbtnfemale.Checked)
            {
                sv.Gender = false;
            }
            return sv;
        }

        private bool isSVExisted(string newmssv)
        {
            return QLSV_BLL.Instane.isSVExisted(newmssv);
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            if (MSSV == "")
            {
                if (isSVExisted(txtid.Text))
                {
                    MessageBox.Show("MSSV " + txtid.Text + " da ton tai", "Chu y", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (QLSV_BLL.Instane.insertSV_DAL(getSV()) != 0)
                   MessageBox.Show("Them thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Them that bai", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                if (QLSV_BLL.Instane.updateSV_BLL(getSV()) != 0)
                   MessageBox.Show("Sua thanh cong", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Sua that bai", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            refresh();
            this.Dispose();
        }

        private void displaySV()
        {
            SV sv = QLSV_BLL.Instane.getSVByMSSV_BLL(MSSV);
            txtid.Text = MSSV;
            txtname.Text = sv.NameSV;
            cbbclass.SelectedIndex = sv.ID_Lop - 1;
            dtpicker.Value = sv.NS;
            if (sv.Gender)
                rbtnmale.Checked = true;
            else
                rbtnfemale.Checked = true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (MSSV != "")
            {
                displaySV();
                txtid.Enabled = false;
            }
        }
    }
}
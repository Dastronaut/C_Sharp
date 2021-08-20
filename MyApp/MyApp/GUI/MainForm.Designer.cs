
namespace MyApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grboxDS = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grboxSearch = new System.Windows.Forms.GroupBox();
            this.cbbloaisp = new System.Windows.Forms.ComboBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grboxbutton = new System.Windows.Forms.GroupBox();
            this.cbbsort = new System.Windows.Forms.ComboBox();
            this.btnsort = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grboxDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grboxSearch.SuspendLayout();
            this.grboxbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 75);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang quản lý bán hàng";
            // 
            // grboxDS
            // 
            this.grboxDS.Controls.Add(this.dataGridView1);
            this.grboxDS.Location = new System.Drawing.Point(1, 244);
            this.grboxDS.Name = "grboxDS";
            this.grboxDS.Size = new System.Drawing.Size(928, 329);
            this.grboxDS.TabIndex = 2;
            this.grboxDS.TabStop = false;
            this.grboxDS.Text = "Danh Sach";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // grboxSearch
            // 
            this.grboxSearch.Controls.Add(this.cbbloaisp);
            this.grboxSearch.Controls.Add(this.txttensp);
            this.grboxSearch.Controls.Add(this.label3);
            this.grboxSearch.Controls.Add(this.label2);
            this.grboxSearch.Location = new System.Drawing.Point(6, 93);
            this.grboxSearch.Name = "grboxSearch";
            this.grboxSearch.Size = new System.Drawing.Size(923, 145);
            this.grboxSearch.TabIndex = 3;
            this.grboxSearch.TabStop = false;
            this.grboxSearch.Text = "Tìm Kiếm";
            // 
            // cbbloaisp
            // 
            this.cbbloaisp.FormattingEnabled = true;
            this.cbbloaisp.Location = new System.Drawing.Point(639, 35);
            this.cbbloaisp.Name = "cbbloaisp";
            this.cbbloaisp.Size = new System.Drawing.Size(209, 24);
            this.cbbloaisp.TabIndex = 2;
            this.cbbloaisp.SelectedIndexChanged += new System.EventHandler(this.cbbloaisp_SelectedIndexChanged);
            // 
            // txttensp
            // 
            this.txttensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttensp.Location = new System.Drawing.Point(88, 33);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(269, 24);
            this.txttensp.TabIndex = 1;
            this.txttensp.TextChanged += new System.EventHandler(this.txttensp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(512, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên SP:";
            // 
            // grboxbutton
            // 
            this.grboxbutton.Controls.Add(this.cbbsort);
            this.grboxbutton.Controls.Add(this.btnsort);
            this.grboxbutton.Controls.Add(this.btndelete);
            this.grboxbutton.Controls.Add(this.btnedit);
            this.grboxbutton.Controls.Add(this.btnrefresh);
            this.grboxbutton.Controls.Add(this.btnadd);
            this.grboxbutton.Location = new System.Drawing.Point(1, 579);
            this.grboxbutton.Name = "grboxbutton";
            this.grboxbutton.Size = new System.Drawing.Size(928, 94);
            this.grboxbutton.TabIndex = 4;
            this.grboxbutton.TabStop = false;
            // 
            // cbbsort
            // 
            this.cbbsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbsort.FormattingEnabled = true;
            this.cbbsort.Location = new System.Drawing.Point(764, 40);
            this.cbbsort.Name = "cbbsort";
            this.cbbsort.Size = new System.Drawing.Size(121, 26);
            this.cbbsort.TabIndex = 1;
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(627, 32);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(102, 38);
            this.btnsort.TabIndex = 0;
            this.btnsort.Text = "Sort";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(476, 32);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(102, 38);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(315, 32);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(102, 38);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(20, 32);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(102, 38);
            this.btnrefresh.TabIndex = 0;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(164, 32);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(102, 38);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 679);
            this.Controls.Add(this.grboxbutton);
            this.Controls.Add(this.grboxSearch);
            this.Controls.Add(this.grboxDS);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grboxDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grboxSearch.ResumeLayout(false);
            this.grboxSearch.PerformLayout();
            this.grboxbutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grboxDS;
        private System.Windows.Forms.GroupBox grboxSearch;
        private System.Windows.Forms.GroupBox grboxbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbsort;
        private System.Windows.Forms.ComboBox cbbloaisp;
    }
}
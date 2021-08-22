
namespace QLTV
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttensahc = new System.Windows.Forms.TextBox();
            this.cbbtheloai = new System.Windows.Forms.ComboBox();
            this.cbbsort = new System.Windows.Forms.ComboBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnsort = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ten sach:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "The Loai:";
            // 
            // txttensahc
            // 
            this.txttensahc.Location = new System.Drawing.Point(164, 39);
            this.txttensahc.Name = "txttensahc";
            this.txttensahc.Size = new System.Drawing.Size(206, 22);
            this.txttensahc.TabIndex = 3;
            this.txttensahc.TextChanged += new System.EventHandler(this.txttensahc_TextChanged);
            // 
            // cbbtheloai
            // 
            this.cbbtheloai.FormattingEnabled = true;
            this.cbbtheloai.Location = new System.Drawing.Point(689, 39);
            this.cbbtheloai.Name = "cbbtheloai";
            this.cbbtheloai.Size = new System.Drawing.Size(249, 24);
            this.cbbtheloai.TabIndex = 4;
            this.cbbtheloai.SelectedIndexChanged += new System.EventHandler(this.cbbtheloai_SelectedIndexChanged);
            // 
            // cbbsort
            // 
            this.cbbsort.FormattingEnabled = true;
            this.cbbsort.Location = new System.Drawing.Point(831, 423);
            this.cbbsort.Name = "cbbsort";
            this.cbbsort.Size = new System.Drawing.Size(107, 24);
            this.cbbsort.TabIndex = 5;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(26, 412);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(113, 45);
            this.btnrefresh.TabIndex = 6;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(672, 412);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(113, 45);
            this.btnsort.TabIndex = 7;
            this.btnsort.Text = "Sort";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(517, 412);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(113, 45);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(354, 412);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(113, 45);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(190, 412);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(113, 45);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 477);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsort);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.cbbsort);
            this.Controls.Add(this.cbbtheloai);
            this.Controls.Add(this.txttensahc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttensahc;
        private System.Windows.Forms.ComboBox cbbtheloai;
        private System.Windows.Forms.ComboBox cbbsort;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
    }
}


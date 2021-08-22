
namespace _102190156_TranKimTienDat
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
            this.txtten = new System.Windows.Forms.TextBox();
            this.cbbTP = new System.Windows.Forms.ComboBox();
            this.cbbsort = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnsort = new System.Windows.Forms.Button();
            this.cbbncc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnfefres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 302);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nha Cung Cap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tinh";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(391, 90);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(214, 22);
            this.txtten.TabIndex = 4;
            this.txtten.TextChanged += new System.EventHandler(this.txtten_TextChanged);
            // 
            // cbbTP
            // 
            this.cbbTP.FormattingEnabled = true;
            this.cbbTP.Location = new System.Drawing.Point(135, 39);
            this.cbbTP.Name = "cbbTP";
            this.cbbTP.Size = new System.Drawing.Size(221, 24);
            this.cbbTP.TabIndex = 5;
            this.cbbTP.SelectedIndexChanged += new System.EventHandler(this.cbbTP_SelectedIndexChanged);
            // 
            // cbbsort
            // 
            this.cbbsort.FormattingEnabled = true;
            this.cbbsort.Location = new System.Drawing.Point(934, 472);
            this.cbbsort.Name = "cbbsort";
            this.cbbsort.Size = new System.Drawing.Size(116, 24);
            this.cbbsort.TabIndex = 6;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(216, 461);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(84, 44);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(402, 461);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(84, 44);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(602, 461);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(84, 44);
            this.btndel.TabIndex = 10;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(777, 461);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(84, 44);
            this.btnsort.TabIndex = 11;
            this.btnsort.Text = "Sort";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // cbbncc
            // 
            this.cbbncc.FormattingEnabled = true;
            this.cbbncc.Location = new System.Drawing.Point(651, 39);
            this.cbbncc.Name = "cbbncc";
            this.cbbncc.Size = new System.Drawing.Size(221, 24);
            this.cbbncc.TabIndex = 12;
            this.cbbncc.SelectedIndexChanged += new System.EventHandler(this.cbbncc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search";
            // 
            // btnfefres
            // 
            this.btnfefres.Location = new System.Drawing.Point(51, 461);
            this.btnfefres.Name = "btnfefres";
            this.btnfefres.Size = new System.Drawing.Size(84, 44);
            this.btnfefres.TabIndex = 14;
            this.btnfefres.Text = "Refresh";
            this.btnfefres.UseVisualStyleBackColor = true;
            this.btnfefres.Click += new System.EventHandler(this.btnfefres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 534);
            this.Controls.Add(this.btnfefres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbncc);
            this.Controls.Add(this.btnsort);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbbsort);
            this.Controls.Add(this.cbbTP);
            this.Controls.Add(this.txtten);
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
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.ComboBox cbbTP;
        private System.Windows.Forms.ComboBox cbbsort;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.ComboBox cbbncc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnfefres;
    }
}


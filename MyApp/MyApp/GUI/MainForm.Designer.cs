
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
            this.grboxChiTiet = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grboxDS = new System.Windows.Forms.GroupBox();
            this.grboxSearch = new System.Windows.Forms.GroupBox();
            this.grboxbutton = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.grboxChiTiet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grboxDS.SuspendLayout();
            this.grboxbutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grboxChiTiet
            // 
            this.grboxChiTiet.Controls.Add(this.btncancel);
            this.grboxChiTiet.Controls.Add(this.btnsave);
            this.grboxChiTiet.Location = new System.Drawing.Point(430, 93);
            this.grboxChiTiet.Name = "grboxChiTiet";
            this.grboxChiTiet.Size = new System.Drawing.Size(499, 480);
            this.grboxChiTiet.TabIndex = 0;
            this.grboxChiTiet.TabStop = false;
            this.grboxChiTiet.Text = "Chi Tiet";
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
            this.grboxDS.Size = new System.Drawing.Size(423, 329);
            this.grboxDS.TabIndex = 2;
            this.grboxDS.TabStop = false;
            this.grboxDS.Text = "Danh Sach";
            // 
            // grboxSearch
            // 
            this.grboxSearch.Location = new System.Drawing.Point(6, 93);
            this.grboxSearch.Name = "grboxSearch";
            this.grboxSearch.Size = new System.Drawing.Size(418, 145);
            this.grboxSearch.TabIndex = 3;
            this.grboxSearch.TabStop = false;
            this.grboxSearch.Text = "Search";
            // 
            // grboxbutton
            // 
            this.grboxbutton.Controls.Add(this.btnexit);
            this.grboxbutton.Controls.Add(this.btndelete);
            this.grboxbutton.Controls.Add(this.btnedit);
            this.grboxbutton.Controls.Add(this.btnsearch);
            this.grboxbutton.Controls.Add(this.btnadd);
            this.grboxbutton.Location = new System.Drawing.Point(1, 579);
            this.grboxbutton.Name = "grboxbutton";
            this.grboxbutton.Size = new System.Drawing.Size(928, 94);
            this.grboxbutton.TabIndex = 4;
            this.grboxbutton.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(164, 32);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(102, 38);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(315, 32);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(102, 38);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(476, 32);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(102, 38);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(627, 32);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(102, 38);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(20, 32);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(102, 38);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(62, 408);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(102, 38);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(312, 408);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(102, 38);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 674);
            this.Controls.Add(this.grboxbutton);
            this.Controls.Add(this.grboxSearch);
            this.Controls.Add(this.grboxDS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grboxChiTiet);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.grboxChiTiet.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grboxDS.ResumeLayout(false);
            this.grboxbutton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxChiTiet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grboxDS;
        private System.Windows.Forms.GroupBox grboxSearch;
        private System.Windows.Forms.GroupBox grboxbutton;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnadd;
    }
}
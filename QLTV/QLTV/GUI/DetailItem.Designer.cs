
namespace QLTV
{
    partial class DetailItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.cbbtheloai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma Sach:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "The Loai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nam XB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ten Sach:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(51, 318);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 53);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(314, 318);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(110, 53);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(161, 32);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(263, 22);
            this.txtma.TabIndex = 6;
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(161, 171);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(263, 22);
            this.txtnam.TabIndex = 8;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(161, 99);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(263, 22);
            this.txtten.TabIndex = 9;
            // 
            // cbbtheloai
            // 
            this.cbbtheloai.FormattingEnabled = true;
            this.cbbtheloai.Location = new System.Drawing.Point(161, 232);
            this.cbbtheloai.Name = "cbbtheloai";
            this.cbbtheloai.Size = new System.Drawing.Size(263, 24);
            this.cbbtheloai.TabIndex = 10;
            // 
            // DetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 396);
            this.Controls.Add(this.cbbtheloai);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailItem";
            this.Text = "DetailItem";
            this.Load += new System.EventHandler(this.DetailItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.ComboBox cbbtheloai;
    }
}

namespace MyApp
{
    partial class ItemDetailForm
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
            this.cbbloaihang = new System.Windows.Forms.ComboBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txtdonvi = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.grboxChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxChiTiet
            // 
            this.grboxChiTiet.Controls.Add(this.cbbloaihang);
            this.grboxChiTiet.Controls.Add(this.txtmasp);
            this.grboxChiTiet.Controls.Add(this.txtdonvi);
            this.grboxChiTiet.Controls.Add(this.txtgia);
            this.grboxChiTiet.Controls.Add(this.txttensp);
            this.grboxChiTiet.Controls.Add(this.label5);
            this.grboxChiTiet.Controls.Add(this.label4);
            this.grboxChiTiet.Controls.Add(this.label3);
            this.grboxChiTiet.Controls.Add(this.label2);
            this.grboxChiTiet.Controls.Add(this.label1);
            this.grboxChiTiet.Controls.Add(this.btncancel);
            this.grboxChiTiet.Controls.Add(this.btnsave);
            this.grboxChiTiet.Location = new System.Drawing.Point(12, 12);
            this.grboxChiTiet.Name = "grboxChiTiet";
            this.grboxChiTiet.Size = new System.Drawing.Size(445, 411);
            this.grboxChiTiet.TabIndex = 1;
            this.grboxChiTiet.TabStop = false;
            this.grboxChiTiet.Text = "Chi Tiet";
            // 
            // cbbloaihang
            // 
            this.cbbloaihang.FormattingEnabled = true;
            this.cbbloaihang.Location = new System.Drawing.Point(183, 271);
            this.cbbloaihang.Name = "cbbloaihang";
            this.cbbloaihang.Size = new System.Drawing.Size(230, 24);
            this.cbbloaihang.TabIndex = 6;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(183, 50);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(231, 22);
            this.txtmasp.TabIndex = 5;
            // 
            // txtdonvi
            // 
            this.txtdonvi.Location = new System.Drawing.Point(183, 146);
            this.txtdonvi.Name = "txtdonvi";
            this.txtdonvi.Size = new System.Drawing.Size(231, 22);
            this.txtdonvi.TabIndex = 4;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(183, 208);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(231, 22);
            this.txtgia.TabIndex = 3;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(183, 97);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(231, 22);
            this.txttensp.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(59, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loại Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(59, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(59, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn vị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(59, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SP:";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(291, 338);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(102, 38);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(73, 338);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(102, 38);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // ItemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 439);
            this.Controls.Add(this.grboxChiTiet);
            this.Name = "ItemDetailForm";
            this.Text = "ItemDetailForm";
            this.Load += new System.EventHandler(this.ItemDetailForm_Load);
            this.grboxChiTiet.ResumeLayout(false);
            this.grboxChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxChiTiet;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbloaihang;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txtdonvi;
        private System.Windows.Forms.TextBox txtgia;
    }
}
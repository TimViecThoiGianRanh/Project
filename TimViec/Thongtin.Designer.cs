namespace TimViec
{
    partial class Thongtin
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Sdt = new DevExpress.XtraEditors.TextEdit();
            this.DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.Ten = new DevExpress.XtraEditors.TextEdit();
            this.btnok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(263, 184);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 17);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Số điện thoại";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(263, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 17);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Địa chỉ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(263, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 17);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Họ và tên";
            // 
            // Sdt
            // 
            this.Sdt.Enabled = false;
            this.Sdt.Location = new System.Drawing.Point(396, 181);
            this.Sdt.Name = "Sdt";
            this.Sdt.Size = new System.Drawing.Size(166, 22);
            this.Sdt.TabIndex = 12;
            // 
            // DiaChi
            // 
            this.DiaChi.Enabled = false;
            this.DiaChi.Location = new System.Drawing.Point(396, 115);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(166, 22);
            this.DiaChi.TabIndex = 11;
            // 
            // Ten
            // 
            this.Ten.Enabled = false;
            this.Ten.Location = new System.Drawing.Point(396, 52);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(166, 22);
            this.Ten.TabIndex = 10;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(263, 263);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 17;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimViec.Properties.Resources._816;
            this.pictureBox1.Location = new System.Drawing.Point(22, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Thongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 327);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Sdt);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.Ten);
            this.Name = "Thongtin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thongtin";
            ((System.ComponentModel.ISupportInitialize)(this.Sdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit Sdt;
        private DevExpress.XtraEditors.TextEdit DiaChi;
        private DevExpress.XtraEditors.TextEdit Ten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnok;
    }
}
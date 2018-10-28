namespace TimViec
{
    partial class ThayDoiMatKhau
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
            this.lblHienthi = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamRong = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhaplaiMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatkhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHienthi
            // 
            this.lblHienthi.AutoSize = true;
            this.lblHienthi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHienthi.Location = new System.Drawing.Point(187, 201);
            this.lblHienthi.Name = "lblHienthi";
            this.lblHienthi.Size = new System.Drawing.Size(122, 17);
            this.lblHienthi.TabIndex = 23;
            this.lblHienthi.Text = "Mật khẩu đã khớp ";
            this.lblHienthi.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(341, 230);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 34);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamRong
            // 
            this.btnLamRong.Location = new System.Drawing.Point(205, 230);
            this.btnLamRong.Name = "btnLamRong";
            this.btnLamRong.Size = new System.Drawing.Size(99, 34);
            this.btnLamRong.TabIndex = 21;
            this.btnLamRong.Text = "Làm rỗng";
            this.btnLamRong.UseVisualStyleBackColor = true;
            this.btnLamRong.Click += new System.EventHandler(this.btnLamRong_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(60, 230);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(99, 34);
            this.btnCapnhat.TabIndex = 20;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "Thay đổi thông tin tài khoản";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNhaplaiMK
            // 
            this.txtNhaplaiMK.Location = new System.Drawing.Point(190, 166);
            this.txtNhaplaiMK.Multiline = true;
            this.txtNhaplaiMK.Name = "txtNhaplaiMK";
            this.txtNhaplaiMK.PasswordChar = '*';
            this.txtNhaplaiMK.Size = new System.Drawing.Size(240, 29);
            this.txtNhaplaiMK.TabIndex = 18;
            this.txtNhaplaiMK.TextChanged += new System.EventHandler(this.txtNhaplaiMK_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(57, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nhập lại mật khẩu :";
            // 
            // txtMatkhauMoi
            // 
            this.txtMatkhauMoi.Location = new System.Drawing.Point(190, 122);
            this.txtMatkhauMoi.Multiline = true;
            this.txtMatkhauMoi.Name = "txtMatkhauMoi";
            this.txtMatkhauMoi.PasswordChar = '*';
            this.txtMatkhauMoi.Size = new System.Drawing.Size(240, 29);
            this.txtMatkhauMoi.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(57, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(190, 84);
            this.txtTenDN.Multiline = true;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(240, 29);
            this.txtTenDN.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // ThayDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 291);
            this.Controls.Add(this.lblHienthi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamRong);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNhaplaiMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatkhauMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.label1);
            this.Name = "ThayDoiMatKhau";
            this.Text = "ThayDoiMatKhau";
            this.Load += new System.EventHandler(this.ThayDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienthi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamRong;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhaplaiMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatkhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label1;
    }
}
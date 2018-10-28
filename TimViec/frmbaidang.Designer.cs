namespace TimViec
{
    partial class frmbaidang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbaidang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.xoa = new DevExpress.XtraBars.BarButtonItem();
            this.luu = new DevExpress.XtraBars.BarButtonItem();
            this.lammoi = new DevExpress.XtraBars.BarButtonItem();
            this.txtmabd = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tim = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.dgbaidang = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbaidang)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.xoa,
            this.luu,
            this.lammoi,
            this.txtmabd,
            this.tim});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.xoa, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.luu, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.lammoi, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.txtmabd, "", true, true, true, 130),
            new DevExpress.XtraBars.LinkPersistInfo(this.tim)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // xoa
            // 
            this.xoa.Caption = "Xóa";
            this.xoa.Glyph = global::TimViec.Properties.Resources.Button_Delete_icon;
            this.xoa.Id = 2;
            this.xoa.Name = "xoa";
            this.xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.xoa_ItemClick);
            // 
            // luu
            // 
            this.luu.Caption = "Lưu";
            this.luu.Glyph = global::TimViec.Properties.Resources.Save_icon;
            this.luu.Id = 3;
            this.luu.Name = "luu";
            this.luu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.luu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.luu_ItemClick);
            // 
            // lammoi
            // 
            this.lammoi.Caption = "Làm mới";
            this.lammoi.Glyph = global::TimViec.Properties.Resources.Button_Refresh_icon;
            this.lammoi.Id = 4;
            this.lammoi.Name = "lammoi";
            this.lammoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.lammoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.lammoi_ItemClick);
            // 
            // txtmabd
            // 
            this.txtmabd.Caption = "mã bài đăng";
            this.txtmabd.Edit = this.repositoryItemTextEdit1;
            this.txtmabd.EditValue = "";
            this.txtmabd.EditWidth = 200;
            this.txtmabd.Id = 6;
            this.txtmabd.Name = "txtmabd";
            this.txtmabd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // tim
            // 
            this.tim.Caption = "Tìm";
            this.tim.Glyph = ((System.Drawing.Image)(resources.GetObject("tim.Glyph")));
            this.tim.Id = 7;
            this.tim.Name = "tim";
            this.tim.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.tim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tim_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(877, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 452);
            this.barDockControlBottom.Size = new System.Drawing.Size(877, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 402);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(877, 50);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 402);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = global::TimViec.Properties.Resources.Button_Add_icon;
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            // 
            // dgbaidang
            // 
            this.dgbaidang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbaidang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgbaidang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbaidang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.linkanh,
            this.luong,
            this.ngaydang,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgbaidang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgbaidang.Location = new System.Drawing.Point(0, 50);
            this.dgbaidang.Name = "dgbaidang";
            this.dgbaidang.RowTemplate.Height = 24;
            this.dgbaidang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbaidang.Size = new System.Drawing.Size(877, 402);
            this.dgbaidang.TabIndex = 4;
            this.dgbaidang.SelectionChanged += new System.EventHandler(this.dgbaidang_SelectionChanged);
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Tiêu đề";
            this.title.Name = "title";
            // 
            // linkanh
            // 
            this.linkanh.DataPropertyName = "image";
            this.linkanh.HeaderText = "Link ảnh";
            this.linkanh.Name = "linkanh";
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.HeaderText = "Lương";
            this.luong.Name = "luong";
            // 
            // ngaydang
            // 
            this.ngaydang.DataPropertyName = "ngaydang";
            this.ngaydang.HeaderText = "Ngày đăng";
            this.ngaydang.Name = "ngaydang";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mabd";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "manhatd";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "macv";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // frmbaidang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 477);
            this.Controls.Add(this.dgbaidang);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmbaidang";
            this.Text = "Quản lý bài đăng";
            this.Load += new System.EventHandler(this.frmbaidang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbaidang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem xoa;
        private DevExpress.XtraBars.BarButtonItem luu;
        private DevExpress.XtraBars.BarButtonItem lammoi;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private System.Windows.Forms.DataGridView dgbaidang;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevExpress.XtraBars.BarEditItem txtmabd;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem tim;
    }
}
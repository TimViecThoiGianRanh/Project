namespace TimViec
{
    partial class themthongtin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(themthongtin));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.them = new DevExpress.XtraBars.BarButtonItem();
            this.btnhuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.lammoi = new DevExpress.XtraBars.BarButtonItem();
            this.tim = new DevExpress.XtraBars.BarButtonItem();
            this.eidtmabd = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Ten = new DevExpress.XtraEditors.TextEdit();
            this.DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.Sdt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sdt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.lammoi,
            this.tim,
            this.eidtmabd,
            this.them,
            this.btnhuy});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 11;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.barManager1.StatusBar = this.bar3;
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
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnhuy)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // them
            // 
            this.them.Caption = "Thêm";
            this.them.Glyph = global::TimViec.Properties.Resources.Button_Add_icon;
            this.them.Id = 9;
            this.them.Name = "them";
            this.them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.them_ItemClick);
            // 
            // btnhuy
            // 
            this.btnhuy.Caption = "Hủy";
            this.btnhuy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnhuy.Glyph")));
            this.btnhuy.Id = 10;
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnhuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnhuy_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(415, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 251);
            this.barDockControlBottom.Size = new System.Drawing.Size(415, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 201);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(415, 50);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 201);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = global::TimViec.Properties.Resources.Button_Add_icon;
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            // 
            // lammoi
            // 
            this.lammoi.Caption = "Làm mới";
            this.lammoi.Glyph = global::TimViec.Properties.Resources.Button_Refresh_icon;
            this.lammoi.Id = 4;
            this.lammoi.Name = "lammoi";
            this.lammoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // tim
            // 
            this.tim.Glyph = ((System.Drawing.Image)(resources.GetObject("tim.Glyph")));
            this.tim.Id = 6;
            this.tim.Name = "tim";
            this.tim.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // eidtmabd
            // 
            this.eidtmabd.Caption = "Mã bài đăng";
            this.eidtmabd.Edit = this.repositoryItemTextEdit2;
            this.eidtmabd.EditValue = "";
            this.eidtmabd.EditWidth = 200;
            this.eidtmabd.Id = 8;
            this.eidtmabd.Name = "eidtmabd";
            this.eidtmabd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(196, 69);
            this.Ten.MenuManager = this.barManager1;
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(166, 22);
            this.Ten.TabIndex = 4;
            // 
            // DiaChi
            // 
            this.DiaChi.Location = new System.Drawing.Point(196, 132);
            this.DiaChi.MenuManager = this.barManager1;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(166, 22);
            this.DiaChi.TabIndex = 5;
            // 
            // Sdt
            // 
            this.Sdt.Location = new System.Drawing.Point(196, 198);
            this.Sdt.MenuManager = this.barManager1;
            this.Sdt.Name = "Sdt";
            this.Sdt.Size = new System.Drawing.Size(166, 22);
            this.Sdt.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(63, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 17);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Họ và tên";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(63, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Địa chỉ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(63, 201);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 17);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Số điện thoại";
            // 
            // themthongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 276);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Sdt);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "themthongtin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "themthongtin";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sdt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem them;
        private DevExpress.XtraBars.BarButtonItem btnhuy;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem lammoi;
        private DevExpress.XtraBars.BarButtonItem tim;
        private DevExpress.XtraBars.BarEditItem eidtmabd;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.TextEdit Sdt;
        private DevExpress.XtraEditors.TextEdit DiaChi;
        private DevExpress.XtraEditors.TextEdit Ten;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
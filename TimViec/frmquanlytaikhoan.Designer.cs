namespace TimViec
{
    partial class frmquanlytaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmquanlytaikhoan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.them = new DevExpress.XtraBars.BarButtonItem();
            this.sua = new DevExpress.XtraBars.BarButtonItem();
            this.xoa = new DevExpress.XtraBars.BarButtonItem();
            this.luu = new DevExpress.XtraBars.BarButtonItem();
            this.lammoi = new DevExpress.XtraBars.BarButtonItem();
            this.txtusername = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tim = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chktaikhoanhd = new System.Windows.Forms.CheckBox();
            this.chktaikhoankhonghd = new System.Windows.Forms.CheckBox();
            this.txtmk = new DevExpress.XtraEditors.TextEdit();
            this.txttaikhoan = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gvtaikhoan = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttaikhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvtaikhoan)).BeginInit();
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
            this.sua,
            this.xoa,
            this.luu,
            this.lammoi,
            this.them,
            this.tim,
            this.txtusername});
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
            this.bar2.FloatLocation = new System.Drawing.Point(404, 187);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.them, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.xoa, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.luu, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.lammoi, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtusername, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.tim)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // them
            // 
            this.them.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.them.Caption = "Thêm";
            this.them.Glyph = global::TimViec.Properties.Resources.Button_Add_icon;
            this.them.Id = 5;
            this.them.Name = "them";
            this.them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.them_ItemClick);
            // 
            // sua
            // 
            this.sua.Caption = "Sữa";
            this.sua.Glyph = global::TimViec.Properties.Resources.Text_Edit_icon;
            this.sua.Id = 1;
            this.sua.Name = "sua";
            this.sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.sua_ItemClick);
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
            // txtusername
            // 
            this.txtusername.Caption = "Tài khoản";
            this.txtusername.Edit = this.repositoryItemTextEdit1;
            this.txtusername.EditValue = "";
            this.txtusername.EditWidth = 200;
            this.txtusername.Id = 7;
            this.txtusername.Name = "txtusername";
            this.txtusername.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.tim.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1085, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 516);
            this.barDockControlBottom.Size = new System.Drawing.Size(1085, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 466);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1085, 50);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 466);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = global::TimViec.Properties.Resources.Button_Add_icon;
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chktaikhoanhd);
            this.layoutControl1.Controls.Add(this.chktaikhoankhonghd);
            this.layoutControl1.Controls.Add(this.txtmk);
            this.layoutControl1.Controls.Add(this.txttaikhoan);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 50);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(758, 43, 312, 437);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1085, 90);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chktaikhoanhd
            // 
            this.chktaikhoanhd.Location = new System.Drawing.Point(551, 44);
            this.chktaikhoanhd.Name = "chktaikhoanhd";
            this.chktaikhoanhd.Size = new System.Drawing.Size(518, 25);
            this.chktaikhoanhd.TabIndex = 7;
            this.chktaikhoanhd.Text = "Tài khoản đang hoạt động";
            this.chktaikhoanhd.UseVisualStyleBackColor = true;
            this.chktaikhoanhd.CheckedChanged += new System.EventHandler(this.chktaikhoanhd_CheckedChanged);
            // 
            // chktaikhoankhonghd
            // 
            this.chktaikhoankhonghd.Location = new System.Drawing.Point(16, 44);
            this.chktaikhoankhonghd.Name = "chktaikhoankhonghd";
            this.chktaikhoankhonghd.Size = new System.Drawing.Size(529, 25);
            this.chktaikhoankhonghd.TabIndex = 6;
            this.chktaikhoankhonghd.Text = "Tài khoản không hoạt động";
            this.chktaikhoankhonghd.UseVisualStyleBackColor = true;
            this.chktaikhoankhonghd.CheckedChanged += new System.EventHandler(this.chktaikhoankhonghd_CheckedChanged);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(614, 16);
            this.txtmk.MenuManager = this.barManager1;
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(455, 22);
            this.txtmk.StyleController = this.layoutControl1;
            this.txtmk.TabIndex = 5;
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(79, 16);
            this.txttaikhoan.MenuManager = this.barManager1;
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(466, 22);
            this.txttaikhoan.StyleController = this.layoutControl1;
            this.txttaikhoan.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1085, 90);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txttaikhoan;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(535, 28);
            this.layoutControlItem1.Text = "Tài khoản";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtmk;
            this.layoutControlItem2.Location = new System.Drawing.Point(535, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(524, 28);
            this.layoutControlItem2.Text = "Mật khẩu";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chktaikhoankhonghd;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(535, 36);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chktaikhoanhd;
            this.layoutControlItem4.Location = new System.Drawing.Point(535, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(524, 36);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // gvtaikhoan
            // 
            this.gvtaikhoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvtaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.type,
            this.tinhtrang});
            this.gvtaikhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvtaikhoan.Location = new System.Drawing.Point(0, 140);
            this.gvtaikhoan.MultiSelect = false;
            this.gvtaikhoan.Name = "gvtaikhoan";
            this.gvtaikhoan.RowTemplate.Height = 24;
            this.gvtaikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvtaikhoan.Size = new System.Drawing.Size(1085, 376);
            this.gvtaikhoan.TabIndex = 5;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Tài khoản";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Mật khẩu";
            this.password.Name = "password";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Column2";
            this.type.Name = "type";
            this.type.Visible = false;
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Column3";
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Visible = false;
            // 
            // frmquanlytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 541);
            this.Controls.Add(this.gvtaikhoan);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmquanlytaikhoan";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmquanlytaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttaikhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvtaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem sua;
        private DevExpress.XtraBars.BarButtonItem xoa;
        private DevExpress.XtraBars.BarButtonItem luu;
        private DevExpress.XtraBars.BarButtonItem lammoi;
        private DevExpress.XtraBars.BarButtonItem them;
        private System.Windows.Forms.DataGridView gvtaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtmk;
        private DevExpress.XtraEditors.TextEdit txttaikhoan;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarButtonItem tim;
        private System.Windows.Forms.CheckBox chktaikhoanhd;
        private System.Windows.Forms.CheckBox chktaikhoankhonghd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.BarEditItem txtusername;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
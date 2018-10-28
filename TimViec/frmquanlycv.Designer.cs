namespace TimViec
{
    partial class frmquanlycv
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
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.them = new DevExpress.XtraBars.BarButtonItem();
            this.sua = new DevExpress.XtraBars.BarButtonItem();
            this.xoa = new DevExpress.XtraBars.BarButtonItem();
            this.luu = new DevExpress.XtraBars.BarButtonItem();
            this.lammoi = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbloaicv = new System.Windows.Forms.ComboBox();
            this.txttencv = new DevExpress.XtraEditors.TextEdit();
            this.txtmacv = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgcongviec = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttencv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcongviec)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
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
            this.them});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.them, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.xoa, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.luu, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.lammoi, true)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(874, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 479);
            this.barDockControlBottom.Size = new System.Drawing.Size(874, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 429);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(874, 50);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 429);
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
            this.layoutControl1.Controls.Add(this.cmbloaicv);
            this.layoutControl1.Controls.Add(this.txttencv);
            this.layoutControl1.Controls.Add(this.txtmacv);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 50);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(874, 86);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbloaicv
            // 
            this.cmbloaicv.FormattingEnabled = true;
            this.cmbloaicv.Items.AddRange(new object[] {
            "all"});
            this.cmbloaicv.Location = new System.Drawing.Point(107, 44);
            this.cmbloaicv.Name = "cmbloaicv";
            this.cmbloaicv.Size = new System.Drawing.Size(751, 24);
            this.cmbloaicv.TabIndex = 6;
            this.cmbloaicv.SelectionChangeCommitted += new System.EventHandler(this.cmbloaicv_SelectionChangeCommitted);
            // 
            // txttencv
            // 
            this.txttencv.Location = new System.Drawing.Point(520, 16);
            this.txttencv.MenuManager = this.barManager1;
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(338, 22);
            this.txttencv.StyleController = this.layoutControl1;
            this.txttencv.TabIndex = 5;
            // 
            // txtmacv
            // 
            this.txtmacv.Location = new System.Drawing.Point(107, 16);
            this.txtmacv.MenuManager = this.barManager1;
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.Size = new System.Drawing.Size(316, 22);
            this.txtmacv.StyleController = this.layoutControl1;
            this.txtmacv.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(874, 86);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtmacv;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(413, 28);
            this.layoutControlItem1.Text = "Mã công việc";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txttencv;
            this.layoutControlItem2.Location = new System.Drawing.Point(413, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(435, 28);
            this.layoutControlItem2.Text = "Tên công việc";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbloaicv;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(848, 32);
            this.layoutControlItem3.Text = "Loại công việc";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(87, 17);
            // 
            // dgcongviec
            // 
            this.dgcongviec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgcongviec.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgcongviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcongviec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.maloai,
            this.Column2,
            this.tenloai});
            this.dgcongviec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcongviec.Location = new System.Drawing.Point(0, 136);
            this.dgcongviec.Name = "dgcongviec";
            this.dgcongviec.RowTemplate.Height = 24;
            this.dgcongviec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgcongviec.Size = new System.Drawing.Size(874, 343);
            this.dgcongviec.TabIndex = 9;
            this.dgcongviec.SelectionChanged += new System.EventHandler(this.dgcongviec_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "macv";
            this.Column1.HeaderText = "Mã công việc";
            this.Column1.Name = "Column1";
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "maloai";
            this.maloai.HeaderText = "Mã loại";
            this.maloai.Name = "maloai";
            this.maloai.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tencv";
            this.Column2.HeaderText = "Tên công việc";
            this.Column2.Name = "Column2";
            // 
            // tenloai
            // 
            this.tenloai.DataPropertyName = "tenloai";
            this.tenloai.HeaderText = "Tên loại";
            this.tenloai.Name = "tenloai";
            // 
            // frmquanlycv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 504);
            this.Controls.Add(this.dgcongviec);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmquanlycv";
            this.Text = "Quản lý công việc";
            this.Load += new System.EventHandler(this.frmquanlycv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txttencv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcongviec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem them;
        private DevExpress.XtraBars.BarButtonItem sua;
        private DevExpress.XtraBars.BarButtonItem xoa;
        private DevExpress.XtraBars.BarButtonItem luu;
        private DevExpress.XtraBars.BarButtonItem lammoi;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.ComboBox cmbloaicv;
        private DevExpress.XtraEditors.TextEdit txttencv;
        private DevExpress.XtraEditors.TextEdit txtmacv;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.DataGridView dgcongviec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
    }
}
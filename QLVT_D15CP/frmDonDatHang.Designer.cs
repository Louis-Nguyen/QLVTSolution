namespace QLVT_D15CP
{
    partial class frmDonDatHang
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
            System.Windows.Forms.Label tENCNLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonDatHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatDDH = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCTDDH = new DevExpress.XtraBars.BarButtonItem();
            this.gbChinhanh = new System.Windows.Forms.GroupBox();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPM = new QLVT_D15CP.DS_DSPM();
            this.v_DS_PHANMANHTableAdapter = new QLVT_D15CP.DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLVT_D15CP.DS_DSPMTableAdapters.TableAdapterManager();
            this.dS = new QLVT_D15CP.DS();
            this.bdsDathang = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT_D15CP.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager1 = new QLVT_D15CP.DSTableAdapters.TableAdapterManager();
            this.gcDDH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbDDH = new System.Windows.Forms.GroupBox();
            this.cmbMAKHO = new System.Windows.Forms.ComboBox();
            this.txtMAKHODDH = new System.Windows.Forms.TextBox();
            this.cmbMANV = new System.Windows.Forms.ComboBox();
            this.txtThongbao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNGAY = new DevExpress.XtraEditors.DateEdit();
            this.txtMANVDDH = new System.Windows.Forms.TextBox();
            this.txtNHACC = new System.Windows.Forms.TextBox();
            this.txtMASODDH = new System.Windows.Forms.TextBox();
            this.btnXoaDDH = new DevExpress.XtraBars.BarButtonItem();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT_D15CP.DSTableAdapters.CTDDHTableAdapter();
            this.cTDDHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tENCNLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.gbChinhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDathang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAY.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(242, 30);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(89, 21);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi nhánh:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(11, 30);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(105, 21);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(9, 169);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(125, 21);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà Cung Cấp:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(376, 30);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(53, 21);
            nGAYLabel.TabIndex = 9;
            nGAYLabel.Text = "Ngày:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(8, 74);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(113, 21);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // mAKHOLabel1
            // 
            mAKHOLabel1.AutoSize = true;
            mAKHOLabel1.Location = new System.Drawing.Point(12, 123);
            mAKHOLabel1.Name = "mAKHOLabel1";
            mAKHOLabel1.Size = new System.Drawing.Size(71, 21);
            mAKHOLabel1.TabIndex = 13;
            mAKHOLabel1.Text = "Mã kho:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemDDH,
            this.btnGhiDDH,
            this.btnSuaDDH,
            this.btnUndoDDH,
            this.btnRefreshDDH,
            this.btnThoatDDH,
            this.btnCTDDH,
            this.btnXoa});
            this.barManager1.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndoDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefreshDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemDDH
            // 
            this.btnThemDDH.Caption = "Thêm";
            this.btnThemDDH.Id = 0;
            this.btnThemDDH.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.icons8_add_property_24;
            this.btnThemDDH.Name = "btnThemDDH";
            this.btnThemDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemDDH_ItemClick);
            // 
            // btnSuaDDH
            // 
            this.btnSuaDDH.Caption = "Sửa";
            this.btnSuaDDH.Id = 3;
            this.btnSuaDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDDH.ImageOptions.Image")));
            this.btnSuaDDH.Name = "btnSuaDDH";
            this.btnSuaDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaDDH_ItemClick);
            // 
            // btnGhiDDH
            // 
            this.btnGhiDDH.Caption = "Ghi";
            this.btnGhiDDH.Id = 2;
            this.btnGhiDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiDDH.ImageOptions.Image")));
            this.btnGhiDDH.Name = "btnGhiDDH";
            this.btnGhiDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiDDH_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 9;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaPN_ItemClick);
            // 
            // btnUndoDDH
            // 
            this.btnUndoDDH.Caption = "Phục hồi";
            this.btnUndoDDH.Id = 5;
            this.btnUndoDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoDDH.ImageOptions.Image")));
            this.btnUndoDDH.Name = "btnUndoDDH";
            this.btnUndoDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoDDH_ItemClick);
            // 
            // btnRefreshDDH
            // 
            this.btnRefreshDDH.Caption = "Tải lại";
            this.btnRefreshDDH.Id = 6;
            this.btnRefreshDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDDH.ImageOptions.Image")));
            this.btnRefreshDDH.Name = "btnRefreshDDH";
            this.btnRefreshDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshDDH_ItemClick);
            // 
            // btnThoatDDH
            // 
            this.btnThoatDDH.Caption = "Thoát";
            this.btnThoatDDH.Id = 7;
            this.btnThoatDDH.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Exit_24_icon;
            this.btnThoatDDH.Name = "btnThoatDDH";
            this.btnThoatDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatDDH_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1182, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 606);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1182, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 547);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1182, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 547);
            // 
            // btnCTDDH
            // 
            this.btnCTDDH.Caption = "Chi tiết đơn đặt hàng";
            this.btnCTDDH.Id = 8;
            this.btnCTDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCTDDH.ImageOptions.Image")));
            this.btnCTDDH.Name = "btnCTDDH";
            // 
            // gbChinhanh
            // 
            this.gbChinhanh.Controls.Add(tENCNLabel);
            this.gbChinhanh.Controls.Add(this.cmbChinhanh);
            this.gbChinhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbChinhanh.Location = new System.Drawing.Point(0, 59);
            this.gbChinhanh.Name = "gbChinhanh";
            this.gbChinhanh.Size = new System.Drawing.Size(1182, 77);
            this.gbChinhanh.TabIndex = 4;
            this.gbChinhanh.TabStop = false;
            this.gbChinhanh.Text = "Chi Nhánh";
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENCN", true));
            this.cmbChinhanh.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cmbChinhanh.DisplayMember = "TENCN";
            this.cmbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(337, 27);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(542, 28);
            this.cmbChinhanh.TabIndex = 1;
            this.cmbChinhanh.ValueMember = "TENSERVER";
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.dS_DSPM;
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVT_D15CP.DS_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDathang
            // 
            this.bdsDathang.DataMember = "DatHang";
            this.bdsDathang.DataSource = this.dS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiNhanhTableAdapter = null;
            this.tableAdapterManager1.CTDDHTableAdapter = null;
            this.tableAdapterManager1.CTPNTableAdapter = null;
            this.tableAdapterManager1.CTPXTableAdapter = null;
            this.tableAdapterManager1.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager1.KhoTableAdapter = null;
            this.tableAdapterManager1.NhanVienTableAdapter = null;
            this.tableAdapterManager1.PhieuNhapTableAdapter = null;
            this.tableAdapterManager1.PhieuXuatTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLVT_D15CP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VattuTableAdapter = null;
            // 
            // gcDDH
            // 
            this.gcDDH.DataSource = this.bdsDathang;
            this.gcDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDDH.Location = new System.Drawing.Point(0, 136);
            this.gcDDH.MainView = this.gridView1;
            this.gcDDH.MenuManager = this.barManager1;
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(1182, 187);
            this.gcDDH.TabIndex = 5;
            this.gcDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcDDH;
            this.gridView1.Name = "gridView1";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã số đơn đặt hàng";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.OptionsColumn.AllowEdit = false;
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày lập phiếu";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà cung cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.OptionsColumn.AllowEdit = false;
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên lập phiếu";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho ";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // gbDDH
            // 
            this.gbDDH.Controls.Add(this.cmbMAKHO);
            this.gbDDH.Controls.Add(mAKHOLabel1);
            this.gbDDH.Controls.Add(this.txtMAKHODDH);
            this.gbDDH.Controls.Add(this.cmbMANV);
            this.gbDDH.Controls.Add(this.txtThongbao);
            this.gbDDH.Controls.Add(this.label1);
            this.gbDDH.Controls.Add(nGAYLabel);
            this.gbDDH.Controls.Add(this.txtNGAY);
            this.gbDDH.Controls.Add(mANVLabel);
            this.gbDDH.Controls.Add(this.txtMANVDDH);
            this.gbDDH.Controls.Add(nhaCCLabel);
            this.gbDDH.Controls.Add(this.txtNHACC);
            this.gbDDH.Controls.Add(masoDDHLabel);
            this.gbDDH.Controls.Add(this.txtMASODDH);
            this.gbDDH.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDDH.Location = new System.Drawing.Point(0, 323);
            this.gbDDH.Name = "gbDDH";
            this.gbDDH.Size = new System.Drawing.Size(657, 283);
            this.gbDDH.TabIndex = 6;
            this.gbDDH.TabStop = false;
            this.gbDDH.Text = "Thông tin đơn đặt hàng";
            // 
            // cmbMAKHO
            // 
            this.cmbMAKHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAKHO.FormattingEnabled = true;
            this.cmbMAKHO.Location = new System.Drawing.Point(140, 120);
            this.cmbMAKHO.Name = "cmbMAKHO";
            this.cmbMAKHO.Size = new System.Drawing.Size(339, 28);
            this.cmbMAKHO.TabIndex = 15;
            this.cmbMAKHO.SelectedIndexChanged += new System.EventHandler(this.cmbMAKHO_SelectedIndexChanged);
            // 
            // txtMAKHODDH
            // 
            this.txtMAKHODDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDathang, "MAKHO", true));
            this.txtMAKHODDH.Enabled = false;
            this.txtMAKHODDH.Location = new System.Drawing.Point(485, 120);
            this.txtMAKHODDH.Name = "txtMAKHODDH";
            this.txtMAKHODDH.Size = new System.Drawing.Size(88, 28);
            this.txtMAKHODDH.TabIndex = 14;
            // 
            // cmbMANV
            // 
            this.cmbMANV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMANV.FormattingEnabled = true;
            this.cmbMANV.Location = new System.Drawing.Point(140, 71);
            this.cmbMANV.Name = "cmbMANV";
            this.cmbMANV.Size = new System.Drawing.Size(339, 28);
            this.cmbMANV.TabIndex = 13;
            this.cmbMANV.SelectedIndexChanged += new System.EventHandler(this.cmbMANV_SelectedIndexChanged);
            // 
            // txtThongbao
            // 
            this.txtThongbao.AutoSize = true;
            this.txtThongbao.Location = new System.Drawing.Point(137, 215);
            this.txtThongbao.Name = "txtThongbao";
            this.txtThongbao.Size = new System.Drawing.Size(0, 21);
            this.txtThongbao.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thông báo:";
            // 
            // txtNGAY
            // 
            this.txtNGAY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDathang, "NGAY", true));
            this.txtNGAY.EditValue = null;
            this.txtNGAY.Location = new System.Drawing.Point(458, 30);
            this.txtNGAY.MenuManager = this.barManager1;
            this.txtNGAY.Name = "txtNGAY";
            this.txtNGAY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAY.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAY.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.txtNGAY.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNGAY.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtNGAY.Size = new System.Drawing.Size(157, 22);
            this.txtNGAY.TabIndex = 10;
            // 
            // txtMANVDDH
            // 
            this.txtMANVDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDathang, "MANV", true));
            this.txtMANVDDH.Enabled = false;
            this.txtMANVDDH.Location = new System.Drawing.Point(485, 71);
            this.txtMANVDDH.Name = "txtMANVDDH";
            this.txtMANVDDH.Size = new System.Drawing.Size(88, 28);
            this.txtMANVDDH.TabIndex = 7;
            // 
            // txtNHACC
            // 
            this.txtNHACC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDathang, "NhaCC", true));
            this.txtNHACC.Location = new System.Drawing.Point(140, 166);
            this.txtNHACC.Name = "txtNHACC";
            this.txtNHACC.Size = new System.Drawing.Size(433, 28);
            this.txtNHACC.TabIndex = 5;
            // 
            // txtMASODDH
            // 
            this.txtMASODDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDathang, "MasoDDH", true));
            this.txtMASODDH.Location = new System.Drawing.Point(140, 27);
            this.txtMASODDH.Name = "txtMASODDH";
            this.txtMASODDH.Size = new System.Drawing.Size(200, 28);
            this.txtMASODDH.TabIndex = 1;
            // 
            // btnXoaDDH
            // 
            this.btnXoaDDH.Caption = "Xóa";
            this.btnXoaDDH.Id = 4;
            this.btnXoaDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDDH.ImageOptions.Image")));
            this.btnXoaDDH.Name = "btnXoaDDH";
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdsCTDDH.DataSource = this.bdsDathang;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // cTDDHDataGridView
            // 
            this.cTDDHDataGridView.AllowUserToAddRows = false;
            this.cTDDHDataGridView.AutoGenerateColumns = false;
            this.cTDDHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTDDHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cTDDHDataGridView.DataSource = this.bdsCTDDH;
            this.cTDDHDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.cTDDHDataGridView.Enabled = false;
            this.cTDDHDataGridView.Location = new System.Drawing.Point(657, 323);
            this.cTDDHDataGridView.Name = "cTDDHDataGridView";
            this.cTDDHDataGridView.RowTemplate.Height = 24;
            this.cTDDHDataGridView.Size = new System.Drawing.Size(525, 283);
            this.cTDDHDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã vật tư";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 606);
            this.Controls.Add(this.cTDDHDataGridView);
            this.Controls.Add(this.gbDDH);
            this.Controls.Add(this.gcDDH);
            this.Controls.Add(this.gbChinhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDonDatHang";
            this.Text = "Quản lí đơn đặt hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.gbChinhanh.ResumeLayout(false);
            this.gbChinhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDathang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbDDH.ResumeLayout(false);
            this.gbDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAY.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox gbChinhanh;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPM dS_DSPM;
        private DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbChinhanh;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsDathang;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl gcDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox gbDDH;
        private System.Windows.Forms.TextBox txtNHACC;
        private System.Windows.Forms.TextBox txtMASODDH;
        private DevExpress.XtraBars.BarButtonItem btnThemDDH;
        private DevExpress.XtraBars.BarButtonItem btnGhiDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraBars.BarButtonItem btnSuaDDH;
        private DevExpress.XtraBars.BarButtonItem btnUndoDDH;
        private DevExpress.XtraBars.BarButtonItem btnRefreshDDH;
        private DevExpress.XtraBars.BarButtonItem btnThoatDDH;
        private DevExpress.XtraEditors.DateEdit txtNGAY;
        private System.Windows.Forms.TextBox txtMANVDDH;
        private DevExpress.XtraBars.BarButtonItem btnXoaDDH;
        private DevExpress.XtraBars.BarButtonItem btnCTDDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtThongbao;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private System.Windows.Forms.ComboBox cmbMANV;
        private System.Windows.Forms.TextBox txtMAKHODDH;
        private System.Windows.Forms.ComboBox cmbMAKHO;
        private System.Windows.Forms.DataGridView cTDDHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
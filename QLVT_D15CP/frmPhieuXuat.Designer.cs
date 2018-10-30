namespace QLVT_D15CP
{
    partial class frmPhieuXuat
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuXuat));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatPX = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gbChinhanh = new System.Windows.Forms.GroupBox();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPM = new QLVT_D15CP.DS_DSPM();
            this.v_DS_PHANMANHTableAdapter = new QLVT_D15CP.DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLVT_D15CP.DS_DSPMTableAdapters.TableAdapterManager();
            this.dS = new QLVT_D15CP.DS();
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT_D15CP.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager1 = new QLVT_D15CP.DSTableAdapters.TableAdapterManager();
            this.cTPXTableAdapter = new QLVT_D15CP.DSTableAdapters.CTPXTableAdapter();
            this.gcPX = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbPX = new System.Windows.Forms.GroupBox();
            this.cmbMAKHO = new System.Windows.Forms.ComboBox();
            this.cmbNhanvien = new System.Windows.Forms.ComboBox();
            this.lbThongbao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHOTENKH = new System.Windows.Forms.TextBox();
            this.txtNGAYPX = new DevExpress.XtraEditors.DateEdit();
            this.txtMAPX = new System.Windows.Forms.TextBox();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtMAKHO = new System.Windows.Forms.TextBox();
            tENCNLabel = new System.Windows.Forms.Label();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.gbChinhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPX.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(282, 38);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(93, 21);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi Nhánh:";
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(27, 54);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(119, 21);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "Mã phiếu xuất:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(330, 54);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(89, 21);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày xuất:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(27, 100);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(102, 21);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "Khách hàng:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(27, 140);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(88, 21);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Nhân viên:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(27, 191);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(71, 21);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã kho:";
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
            this.btnThemPX,
            this.btnSuaPX,
            this.btnGhiPX,
            this.btnXoaPX,
            this.btnRefreshPX,
            this.btnThoatPX,
            this.btnUndoPX});
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndoPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefreshPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemPX
            // 
            this.btnThemPX.Caption = "Thêm";
            this.btnThemPX.Id = 0;
            this.btnThemPX.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.icons8_add_property_24;
            this.btnThemPX.Name = "btnThemPX";
            this.btnThemPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemPX_ItemClick);
            // 
            // btnSuaPX
            // 
            this.btnSuaPX.Caption = "Sửa";
            this.btnSuaPX.Id = 1;
            this.btnSuaPX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPX.ImageOptions.Image")));
            this.btnSuaPX.Name = "btnSuaPX";
            this.btnSuaPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaPX_ItemClick);
            // 
            // btnGhiPX
            // 
            this.btnGhiPX.Caption = "Ghi";
            this.btnGhiPX.Id = 2;
            this.btnGhiPX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiPX.ImageOptions.Image")));
            this.btnGhiPX.Name = "btnGhiPX";
            this.btnGhiPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiPX_ItemClick);
            // 
            // btnXoaPX
            // 
            this.btnXoaPX.Caption = "Xóa";
            this.btnXoaPX.Id = 3;
            this.btnXoaPX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPX.ImageOptions.Image")));
            this.btnXoaPX.Name = "btnXoaPX";
            this.btnXoaPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaPX_ItemClick);
            // 
            // btnUndoPX
            // 
            this.btnUndoPX.Caption = "Phục hồi";
            this.btnUndoPX.Id = 7;
            this.btnUndoPX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoPX.ImageOptions.Image")));
            this.btnUndoPX.Name = "btnUndoPX";
            this.btnUndoPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoPX_ItemClick);
            // 
            // btnRefreshPX
            // 
            this.btnRefreshPX.Caption = "Tải lại";
            this.btnRefreshPX.Id = 5;
            this.btnRefreshPX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshPX.ImageOptions.Image")));
            this.btnRefreshPX.Name = "btnRefreshPX";
            this.btnRefreshPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshPX_ItemClick);
            // 
            // btnThoatPX
            // 
            this.btnThoatPX.Caption = "Thoát";
            this.btnThoatPX.Id = 6;
            this.btnThoatPX.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Exit_24_icon;
            this.btnThoatPX.Name = "btnThoatPX";
            this.btnThoatPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatPX_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1161, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 747);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1161, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 688);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1161, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 688);
            // 
            // gbChinhanh
            // 
            this.gbChinhanh.Controls.Add(tENCNLabel);
            this.gbChinhanh.Controls.Add(this.cmbChinhanh);
            this.gbChinhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbChinhanh.Location = new System.Drawing.Point(0, 59);
            this.gbChinhanh.Name = "gbChinhanh";
            this.gbChinhanh.Size = new System.Drawing.Size(1161, 100);
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
            this.cmbChinhanh.Location = new System.Drawing.Point(381, 35);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(482, 28);
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
            // bdsPX
            // 
            this.bdsPX.DataMember = "PhieuXuat";
            this.bdsPX.DataSource = this.dS;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiNhanhTableAdapter = null;
            this.tableAdapterManager1.CTDDHTableAdapter = null;
            this.tableAdapterManager1.CTPNTableAdapter = null;
            this.tableAdapterManager1.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager1.DatHangTableAdapter = null;
            this.tableAdapterManager1.KhoTableAdapter = null;
            this.tableAdapterManager1.NhanVienTableAdapter = null;
            this.tableAdapterManager1.PhieuNhapTableAdapter = null;
            this.tableAdapterManager1.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager1.UpdateOrder = QLVT_D15CP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VattuTableAdapter = null;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // gcPX
            // 
            this.gcPX.DataSource = this.bdsPX;
            this.gcPX.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPX.Location = new System.Drawing.Point(0, 159);
            this.gcPX.MainView = this.gridView1;
            this.gcPX.MenuManager = this.barManager1;
            this.gcPX.Name = "gcPX";
            this.gcPX.Size = new System.Drawing.Size(1161, 220);
            this.gcPX.TabIndex = 5;
            this.gcPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcPX;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã phiếu xuất";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.OptionsColumn.AllowEdit = false;
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày xuất hàng";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ tên khách hàng";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.OptionsColumn.AllowEdit = false;
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên xuất hàng";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // gbPX
            // 
            this.gbPX.Controls.Add(this.txtMAKHO);
            this.gbPX.Controls.Add(this.txtMANV);
            this.gbPX.Controls.Add(this.cmbMAKHO);
            this.gbPX.Controls.Add(this.cmbNhanvien);
            this.gbPX.Controls.Add(this.lbThongbao);
            this.gbPX.Controls.Add(this.label1);
            this.gbPX.Controls.Add(mAKHOLabel);
            this.gbPX.Controls.Add(mANVLabel);
            this.gbPX.Controls.Add(hOTENKHLabel);
            this.gbPX.Controls.Add(this.txtHOTENKH);
            this.gbPX.Controls.Add(nGAYLabel);
            this.gbPX.Controls.Add(this.txtNGAYPX);
            this.gbPX.Controls.Add(mAPXLabel);
            this.gbPX.Controls.Add(this.txtMAPX);
            this.gbPX.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPX.Location = new System.Drawing.Point(0, 379);
            this.gbPX.Name = "gbPX";
            this.gbPX.Size = new System.Drawing.Size(648, 368);
            this.gbPX.TabIndex = 6;
            this.gbPX.TabStop = false;
            this.gbPX.Text = "Chi tiết Phiếu xuất";
            // 
            // cmbMAKHO
            // 
            this.cmbMAKHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAKHO.FormattingEnabled = true;
            this.cmbMAKHO.Location = new System.Drawing.Point(152, 188);
            this.cmbMAKHO.Name = "cmbMAKHO";
            this.cmbMAKHO.Size = new System.Drawing.Size(207, 28);
            this.cmbMAKHO.TabIndex = 13;
            this.cmbMAKHO.SelectedIndexChanged += new System.EventHandler(this.cmbMAKHO_SelectedIndexChanged);
            // 
            // cmbNhanvien
            // 
            this.cmbNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanvien.FormattingEnabled = true;
            this.cmbNhanvien.Location = new System.Drawing.Point(152, 140);
            this.cmbNhanvien.Name = "cmbNhanvien";
            this.cmbNhanvien.Size = new System.Drawing.Size(207, 28);
            this.cmbNhanvien.TabIndex = 12;
            this.cmbNhanvien.SelectedIndexChanged += new System.EventHandler(this.cmbNhanvien_SelectedIndexChanged);
            // 
            // lbThongbao
            // 
            this.lbThongbao.AutoSize = true;
            this.lbThongbao.Location = new System.Drawing.Point(155, 237);
            this.lbThongbao.Name = "lbThongbao";
            this.lbThongbao.Size = new System.Drawing.Size(0, 21);
            this.lbThongbao.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thông báo:";
            // 
            // txtHOTENKH
            // 
            this.txtHOTENKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "HOTENKH", true));
            this.txtHOTENKH.Location = new System.Drawing.Point(152, 97);
            this.txtHOTENKH.Name = "txtHOTENKH";
            this.txtHOTENKH.Size = new System.Drawing.Size(448, 28);
            this.txtHOTENKH.TabIndex = 5;
            // 
            // txtNGAYPX
            // 
            this.txtNGAYPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "NGAY", true));
            this.txtNGAYPX.EditValue = null;
            this.txtNGAYPX.Location = new System.Drawing.Point(455, 54);
            this.txtNGAYPX.MenuManager = this.barManager1;
            this.txtNGAYPX.Name = "txtNGAYPX";
            this.txtNGAYPX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYPX.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYPX.Size = new System.Drawing.Size(145, 22);
            this.txtNGAYPX.TabIndex = 3;
            // 
            // txtMAPX
            // 
            this.txtMAPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAPX", true));
            this.txtMAPX.Location = new System.Drawing.Point(152, 51);
            this.txtMAPX.Name = "txtMAPX";
            this.txtMAPX.Size = new System.Drawing.Size(145, 28);
            this.txtMAPX.TabIndex = 1;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_PX";
            this.bdsCTPX.DataSource = this.bdsPX;
            // 
            // cTPXDataGridView
            // 
            this.cTPXDataGridView.AllowUserToAddRows = false;
            this.cTPXDataGridView.AutoGenerateColumns = false;
            this.cTPXDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTPXDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cTPXDataGridView.DataSource = this.bdsCTPX;
            this.cTPXDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.cTPXDataGridView.Location = new System.Drawing.Point(648, 379);
            this.cTPXDataGridView.Name = "cTPXDataGridView";
            this.cTPXDataGridView.RowTemplate.Height = 24;
            this.cTPXDataGridView.Size = new System.Drawing.Size(513, 368);
            this.cTPXDataGridView.TabIndex = 11;
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
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(381, 140);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 28);
            this.txtMANV.TabIndex = 14;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAKHO", true));
            this.txtMAKHO.Location = new System.Drawing.Point(381, 191);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(100, 28);
            this.txtMAKHO.TabIndex = 15;
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 747);
            this.Controls.Add(this.cTPXDataGridView);
            this.Controls.Add(this.gbPX);
            this.Controls.Add(this.gcPX);
            this.Controls.Add(this.gbChinhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuXuat";
            this.Text = "Quản lí Phiếu Xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.gbChinhanh.ResumeLayout(false);
            this.gbChinhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbPX.ResumeLayout(false);
            this.gbPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPX.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemPX;
        private DevExpress.XtraBars.BarButtonItem btnSuaPX;
        private DevExpress.XtraBars.BarButtonItem btnGhiPX;
        private DevExpress.XtraBars.BarButtonItem btnXoaPX;
        private DevExpress.XtraBars.BarButtonItem btnUndoPX;
        private DevExpress.XtraBars.BarButtonItem btnRefreshPX;
        private DevExpress.XtraBars.BarButtonItem btnThoatPX;
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
        private System.Windows.Forms.BindingSource bdsPX;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl gcPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.GroupBox gbPX;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private System.Windows.Forms.Label lbThongbao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHOTENKH;
        private DevExpress.XtraEditors.DateEdit txtNGAYPX;
        private System.Windows.Forms.TextBox txtMAPX;
        private System.Windows.Forms.DataGridView cTPXDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox cmbMAKHO;
        private System.Windows.Forms.ComboBox cmbNhanvien;
        private System.Windows.Forms.TextBox txtMAKHO;
        private System.Windows.Forms.TextBox txtMANV;
    }
}
namespace QLVT_D15CP
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label mACNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnCCN = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatNV = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gbChiNhanh = new System.Windows.Forms.GroupBox();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.bdsDSPM = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPM = new QLVT_D15CP.DS_DSPM();
            this.v_DS_PHANMANHTableAdapter = new QLVT_D15CP.DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLVT_D15CP.DS_DSPMTableAdapters.TableAdapterManager();
            this.dS = new QLVT_D15CP.DS();
            this.bdsNhanvien = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT_D15CP.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager1 = new QLVT_D15CP.DSTableAdapters.TableAdapterManager();
            this.gcNhanvien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbCTNV = new System.Windows.Forms.GroupBox();
            this.lbThongbao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTTX = new System.Windows.Forms.TextBox();
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.txtLUONG = new System.Windows.Forms.TextBox();
            this.txtNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.txtHO = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            tENCNLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.gbChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbCTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYSINH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(241, 30);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(93, 21);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi Nhánh:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(95, 34);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(113, 21);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(424, 30);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(86, 21);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ và tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(421, 91);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(69, 21);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(95, 91);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(88, 21);
            nGAYSINHLabel.TabIndex = 8;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Location = new System.Drawing.Point(95, 146);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(63, 21);
            lUONGLabel.TabIndex = 10;
            lUONGLabel.Text = "Lương:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(424, 146);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(114, 21);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "Mã chi nhánh:";
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
            this.btnThemNV,
            this.btnSuaNV,
            this.btnGhiNV,
            this.btnXoaNV,
            this.btnUndoNV,
            this.btnRefreshNV,
            this.btnCCN,
            this.btnThoatNV});
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndoNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefreshNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCCN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Caption = "Thêm";
            this.btnThemNV.Id = 0;
            this.btnThemNV.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Actions_list_add_user_icon_241;
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemNV_ItemClick);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Caption = "Sửa";
            this.btnSuaNV.Id = 1;
            this.btnSuaNV.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Text_Edit_icon_24;
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaNV_ItemClick);
            // 
            // btnGhiNV
            // 
            this.btnGhiNV.Caption = "Ghi";
            this.btnGhiNV.Id = 2;
            this.btnGhiNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiNV.ImageOptions.Image")));
            this.btnGhiNV.Name = "btnGhiNV";
            this.btnGhiNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiNV_ItemClick);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Caption = "Xóa";
            this.btnXoaNV.Id = 3;
            this.btnXoaNV.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Delete_2_icon_24;
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaNV_ItemClick);
            // 
            // btnUndoNV
            // 
            this.btnUndoNV.Caption = "Phục hồi";
            this.btnUndoNV.Id = 4;
            this.btnUndoNV.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Undo_icon_24;
            this.btnUndoNV.Name = "btnUndoNV";
            this.btnUndoNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoNV_ItemClick);
            // 
            // btnRefreshNV
            // 
            this.btnRefreshNV.Caption = "Tải lại";
            this.btnRefreshNV.Id = 5;
            this.btnRefreshNV.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Button_Refresh_icon_24;
            this.btnRefreshNV.Name = "btnRefreshNV";
            this.btnRefreshNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshNV_ItemClick);
            // 
            // btnCCN
            // 
            this.btnCCN.Caption = "Chuyển chi nhánh";
            this.btnCCN.Id = 6;
            this.btnCCN.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.icons8_queue_241;
            this.btnCCN.Name = "btnCCN";
            this.btnCCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCCN_ItemClick);
            // 
            // btnThoatNV
            // 
            this.btnThoatNV.Caption = "Thoát";
            this.btnThoatNV.Id = 7;
            this.btnThoatNV.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Exit_24_icon2;
            this.btnThoatNV.Name = "btnThoatNV";
            this.btnThoatNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatNV_ItemClick);
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
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1074, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 657);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1074, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 598);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1074, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 598);
            // 
            // gbChiNhanh
            // 
            this.gbChiNhanh.Controls.Add(tENCNLabel);
            this.gbChiNhanh.Controls.Add(this.cmbChinhanh);
            this.gbChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbChiNhanh.Location = new System.Drawing.Point(0, 59);
            this.gbChiNhanh.Name = "gbChiNhanh";
            this.gbChiNhanh.Size = new System.Drawing.Size(1074, 78);
            this.gbChiNhanh.TabIndex = 4;
            this.gbChiNhanh.TabStop = false;
            this.gbChiNhanh.Text = "Chi Nhánh";
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSPM, "TENCN", true));
            this.cmbChinhanh.DataSource = this.bdsDSPM;
            this.cmbChinhanh.DisplayMember = "TENCN";
            this.cmbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(340, 27);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(478, 28);
            this.cmbChinhanh.TabIndex = 1;
            this.cmbChinhanh.ValueMember = "TENSERVER";
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // bdsDSPM
            // 
            this.bdsDSPM.DataMember = "V_DS_PHANMANH";
            this.bdsDSPM.DataSource = this.dS_DSPM;
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
            // bdsNhanvien
            // 
            this.bdsNhanvien.DataMember = "NhanVien";
            this.bdsNhanvien.DataSource = this.dS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiNhanhTableAdapter = null;
            this.tableAdapterManager1.CTDDHTableAdapter = null;
            this.tableAdapterManager1.CTPNTableAdapter = null;
            this.tableAdapterManager1.CTPXTableAdapter = null;
            this.tableAdapterManager1.DatHangTableAdapter = null;
            this.tableAdapterManager1.KhoTableAdapter = null;
            this.tableAdapterManager1.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager1.PhieuNhapTableAdapter = null;
            this.tableAdapterManager1.PhieuXuatTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLVT_D15CP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VattuTableAdapter = null;
            // 
            // gcNhanvien
            // 
            this.gcNhanvien.DataSource = this.bdsNhanvien;
            this.gcNhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanvien.Location = new System.Drawing.Point(0, 137);
            this.gcNhanvien.MainView = this.gridView1;
            this.gcNhanvien.MenuManager = this.barManager1;
            this.gcNhanvien.Name = "gcNhanvien";
            this.gcNhanvien.Size = new System.Drawing.Size(1074, 260);
            this.gcNhanvien.TabIndex = 5;
            this.gcNhanvien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN});
            this.gridView1.GridControl = this.gcNhanvien;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "Lương";
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.OptionsColumn.AllowEdit = false;
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // gbCTNV
            // 
            this.gbCTNV.AutoSize = true;
            this.gbCTNV.Controls.Add(this.lbThongbao);
            this.gbCTNV.Controls.Add(this.label1);
            this.gbCTNV.Controls.Add(this.txtTTX);
            this.gbCTNV.Controls.Add(mACNLabel);
            this.gbCTNV.Controls.Add(this.txtMACN);
            this.gbCTNV.Controls.Add(lUONGLabel);
            this.gbCTNV.Controls.Add(this.txtLUONG);
            this.gbCTNV.Controls.Add(nGAYSINHLabel);
            this.gbCTNV.Controls.Add(this.txtNGAYSINH);
            this.gbCTNV.Controls.Add(dIACHILabel);
            this.gbCTNV.Controls.Add(this.txtDIACHI);
            this.gbCTNV.Controls.Add(this.txtTEN);
            this.gbCTNV.Controls.Add(hOLabel);
            this.gbCTNV.Controls.Add(this.txtHO);
            this.gbCTNV.Controls.Add(mANVLabel);
            this.gbCTNV.Controls.Add(this.txtMANV);
            this.gbCTNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCTNV.Location = new System.Drawing.Point(0, 397);
            this.gbCTNV.Name = "gbCTNV";
            this.gbCTNV.Size = new System.Drawing.Size(1074, 237);
            this.gbCTNV.TabIndex = 6;
            this.gbCTNV.TabStop = false;
            this.gbCTNV.Text = "Chi tiết nhân viên";
            // 
            // lbThongbao
            // 
            this.lbThongbao.AutoSize = true;
            this.lbThongbao.Location = new System.Drawing.Point(214, 192);
            this.lbThongbao.Name = "lbThongbao";
            this.lbThongbao.Size = new System.Drawing.Size(0, 21);
            this.lbThongbao.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thông báo:";
            // 
            // txtTTX
            // 
            this.txtTTX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanvien, "TrangThaiXoa", true));
            this.txtTTX.Location = new System.Drawing.Point(670, 143);
            this.txtTTX.Name = "txtTTX";
            this.txtTTX.Size = new System.Drawing.Size(39, 28);
            this.txtTTX.TabIndex = 15;
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanvien, "MACN", true));
            this.txtMACN.Location = new System.Drawing.Point(544, 143);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(113, 28);
            this.txtMACN.TabIndex = 13;
            // 
            // txtLUONG
            // 
            this.txtLUONG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanvien, "LUONG", true));
            this.txtLUONG.Location = new System.Drawing.Point(214, 143);
            this.txtLUONG.Name = "txtLUONG";
            this.txtLUONG.Size = new System.Drawing.Size(160, 28);
            this.txtLUONG.TabIndex = 11;
            // 
            // txtNGAYSINH
            // 
            this.txtNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanvien, "NGAYSINH", true));
            this.txtNGAYSINH.EditValue = null;
            this.txtNGAYSINH.Location = new System.Drawing.Point(214, 91);
            this.txtNGAYSINH.MenuManager = this.barManager1;
            this.txtNGAYSINH.Name = "txtNGAYSINH";
            this.txtNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYSINH.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.txtNGAYSINH.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNGAYSINH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtNGAYSINH.Size = new System.Drawing.Size(160, 22);
            this.txtNGAYSINH.TabIndex = 9;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanvien, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(516, 88);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(363, 28);
            this.txtDIACHI.TabIndex = 7;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanvien, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(776, 27);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(100, 28);
            this.txtTEN.TabIndex = 5;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanvien, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(516, 27);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(254, 28);
            this.txtHO.TabIndex = 3;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanvien, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(214, 27);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(160, 28);
            this.txtMANV.TabIndex = 1;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 682);
            this.Controls.Add(this.gbCTNV);
            this.Controls.Add(this.gcNhanvien);
            this.Controls.Add(this.gbChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Quản lí nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.gbChiNhanh.ResumeLayout(false);
            this.gbChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbCTNV.ResumeLayout(false);
            this.gbCTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYSINH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemNV;
        private DevExpress.XtraBars.BarButtonItem btnSuaNV;
        private DevExpress.XtraBars.BarButtonItem btnGhiNV;
        private DevExpress.XtraBars.BarButtonItem btnXoaNV;
        private DevExpress.XtraBars.BarButtonItem btnUndoNV;
        private DevExpress.XtraBars.BarButtonItem btnRefreshNV;
        private DevExpress.XtraBars.BarButtonItem btnCCN;
        private DevExpress.XtraBars.BarButtonItem btnThoatNV;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox gbChiNhanh;
        private System.Windows.Forms.BindingSource bdsDSPM;
        private DS_DSPM dS_DSPM;
        private DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbChinhanh;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsNhanvien;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl gcNhanvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.GroupBox gbCTNV;
        private System.Windows.Forms.TextBox txtTTX;
        private System.Windows.Forms.TextBox txtMACN;
        private System.Windows.Forms.TextBox txtLUONG;
        private DevExpress.XtraEditors.DateEdit txtNGAYSINH;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.TextBox txtHO;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbThongbao;
    }
}
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
            System.Windows.Forms.Label mAKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonDatHang));
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mANVLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatDDH = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
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
            this.txtMAKHO = new System.Windows.Forms.TextBox();
            this.txtNHACC = new System.Windows.Forms.TextBox();
            this.txtMASODDH = new System.Windows.Forms.TextBox();
            this.btnXoaDDH = new DevExpress.XtraBars.BarButtonItem();
            this.txtNGAY = new DevExpress.XtraEditors.DateEdit();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.btnCTDDH = new DevExpress.XtraBars.BarButtonItem();
            tENCNLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(185, 30);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(89, 21);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi nhánh:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(106, 62);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(105, 21);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(415, 121);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(125, 21);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà Cung Cấp:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(765, 62);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(71, 21);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã kho:";
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
            this.btnThemDDH,
            this.btnGhiDDH,
            this.btnSuaDDH,
            this.btnUndoDDH,
            this.btnRefreshDDH,
            this.btnThoatDDH,
            this.btnCTDDH});
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndoDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefreshDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCTDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemDDH
            // 
            this.btnThemDDH.Caption = "Thêm";
            this.btnThemDDH.Id = 0;
            this.btnThemDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDDH.ImageOptions.Image")));
            this.btnThemDDH.Name = "btnThemDDH";
            // 
            // btnSuaDDH
            // 
            this.btnSuaDDH.Caption = "Sửa";
            this.btnSuaDDH.Id = 3;
            this.btnSuaDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDDH.ImageOptions.Image")));
            this.btnSuaDDH.Name = "btnSuaDDH";
            // 
            // btnGhiDDH
            // 
            this.btnGhiDDH.Caption = "Ghi";
            this.btnGhiDDH.Id = 2;
            this.btnGhiDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiDDH.ImageOptions.Image")));
            this.btnGhiDDH.Name = "btnGhiDDH";
            // 
            // btnUndoDDH
            // 
            this.btnUndoDDH.Caption = "Phục hồi";
            this.btnUndoDDH.Id = 5;
            this.btnUndoDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoDDH.ImageOptions.Image")));
            this.btnUndoDDH.Name = "btnUndoDDH";
            // 
            // btnRefreshDDH
            // 
            this.btnRefreshDDH.Caption = "Tải lại";
            this.btnRefreshDDH.Id = 6;
            this.btnRefreshDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDDH.ImageOptions.Image")));
            this.btnRefreshDDH.Name = "btnRefreshDDH";
            // 
            // btnThoatDDH
            // 
            this.btnThoatDDH.Caption = "Thoát";
            this.btnThoatDDH.Id = 7;
            this.btnThoatDDH.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Exit_24_icon;
            this.btnThoatDDH.Name = "btnThoatDDH";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1164, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 509);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1164, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1164, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 450);
            // 
            // gbChinhanh
            // 
            this.gbChinhanh.Controls.Add(tENCNLabel);
            this.gbChinhanh.Controls.Add(this.cmbChinhanh);
            this.gbChinhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbChinhanh.Location = new System.Drawing.Point(0, 59);
            this.gbChinhanh.Name = "gbChinhanh";
            this.gbChinhanh.Size = new System.Drawing.Size(1164, 76);
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
            this.cmbChinhanh.Location = new System.Drawing.Point(280, 27);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(542, 28);
            this.cmbChinhanh.TabIndex = 1;
            this.cmbChinhanh.ValueMember = "TENSERVER";
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
            this.gcDDH.Location = new System.Drawing.Point(0, 135);
            this.gcDDH.MainView = this.gridView1;
            this.gcDDH.MenuManager = this.barManager1;
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(1164, 206);
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
            this.colNGAY.Caption = "Ngày ";
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
            this.gbDDH.Controls.Add(nGAYLabel);
            this.gbDDH.Controls.Add(this.txtNGAY);
            this.gbDDH.Controls.Add(mAKHOLabel);
            this.gbDDH.Controls.Add(this.txtMAKHO);
            this.gbDDH.Controls.Add(mANVLabel);
            this.gbDDH.Controls.Add(this.txtMANV);
            this.gbDDH.Controls.Add(nhaCCLabel);
            this.gbDDH.Controls.Add(this.txtNHACC);
            this.gbDDH.Controls.Add(masoDDHLabel);
            this.gbDDH.Controls.Add(this.txtMASODDH);
            this.gbDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDDH.Location = new System.Drawing.Point(0, 341);
            this.gbDDH.Name = "gbDDH";
            this.gbDDH.Size = new System.Drawing.Size(1164, 193);
            this.gbDDH.TabIndex = 6;
            this.gbDDH.TabStop = false;
            this.gbDDH.Text = "Thông tin đơn đặt hàng";
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDathang, "MAKHO", true));
            this.txtMAKHO.Location = new System.Drawing.Point(842, 59);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(149, 28);
            this.txtMAKHO.TabIndex = 9;
            // 
            // txtNHACC
            // 
            this.txtNHACC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDathang, "NhaCC", true));
            this.txtNHACC.Location = new System.Drawing.Point(546, 118);
            this.txtNHACC.Name = "txtNHACC";
            this.txtNHACC.Size = new System.Drawing.Size(445, 28);
            this.txtNHACC.TabIndex = 5;
            // 
            // txtMASODDH
            // 
            this.txtMASODDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDathang, "MasoDDH", true));
            this.txtMASODDH.Location = new System.Drawing.Point(217, 59);
            this.txtMASODDH.Name = "txtMASODDH";
            this.txtMASODDH.Size = new System.Drawing.Size(150, 28);
            this.txtMASODDH.TabIndex = 1;
            // 
            // btnXoaDDH
            // 
            this.btnXoaDDH.Caption = "Xóa";
            this.btnXoaDDH.Id = 4;
            this.btnXoaDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDDH.ImageOptions.Image")));
            this.btnXoaDDH.Name = "btnXoaDDH";
            // 
            // txtNGAY
            // 
            this.txtNGAY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDathang, "NGAY", true));
            this.txtNGAY.EditValue = null;
            this.txtNGAY.Location = new System.Drawing.Point(217, 121);
            this.txtNGAY.MenuManager = this.barManager1;
            this.txtNGAY.Name = "txtNGAY";
            this.txtNGAY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAY.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAY.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.txtNGAY.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNGAY.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtNGAY.Size = new System.Drawing.Size(150, 22);
            this.txtNGAY.TabIndex = 10;
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(142, 121);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(53, 21);
            nGAYLabel.TabIndex = 9;
            nGAYLabel.Text = "Ngày:";
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDathang, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(546, 59);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(149, 28);
            this.txtMANV.TabIndex = 7;
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(418, 62);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(113, 21);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // btnCTDDH
            // 
            this.btnCTDDH.Caption = "Chi tiết đơn đặt hàng";
            this.btnCTDDH.Id = 8;
            this.btnCTDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCTDDH.ImageOptions.Image")));
            this.btnCTDDH.Name = "btnCTDDH";
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 534);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
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
        private System.Windows.Forms.TextBox txtMAKHO;
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
        private System.Windows.Forms.TextBox txtMANV;
        private DevExpress.XtraBars.BarButtonItem btnXoaDDH;
        private DevExpress.XtraBars.BarButtonItem btnCTDDH;
    }
}
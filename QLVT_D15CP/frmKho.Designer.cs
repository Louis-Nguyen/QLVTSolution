namespace QLVT_D15CP
{
    partial class frmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            System.Windows.Forms.Label tENCNLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mACNLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatKho = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gbChinhanh = new System.Windows.Forms.GroupBox();
            this.dS_DSPM = new QLVT_D15CP.DS_DSPM();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLVT_D15CP.DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLVT_D15CP.DS_DSPMTableAdapters.TableAdapterManager();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.dS = new QLVT_D15CP.DS();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVT_D15CP.DSTableAdapters.KhoTableAdapter();
            this.tableAdapterManager1 = new QLVT_D15CP.DSTableAdapters.TableAdapterManager();
            this.gcKho = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbCTKho = new System.Windows.Forms.GroupBox();
            this.txtMAKHO = new System.Windows.Forms.TextBox();
            this.txtTENKHO = new System.Windows.Forms.TextBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbThongbaoKho = new System.Windows.Forms.Label();
            tENCNLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.gbChinhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbCTKho.SuspendLayout();
            this.SuspendLayout();
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
            this.btnThemKho,
            this.btnSuaKho,
            this.btnGhiKho,
            this.btnXoaKho,
            this.btnUndoKho,
            this.btnRefreshKho,
            this.btnThoatKho});
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndoKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefreshKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemKho
            // 
            this.btnThemKho.Caption = "Thêm";
            this.btnThemKho.Id = 0;
            this.btnThemKho.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.icons8_factory_241;
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemKho_ItemClick);
            // 
            // btnSuaKho
            // 
            this.btnSuaKho.Caption = "Sửa";
            this.btnSuaKho.Id = 1;
            this.btnSuaKho.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Text_Edit_icon_24;
            this.btnSuaKho.Name = "btnSuaKho";
            this.btnSuaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaKho_ItemClick);
            // 
            // btnGhiKho
            // 
            this.btnGhiKho.Caption = "Ghi";
            this.btnGhiKho.Id = 2;
            this.btnGhiKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiKho.ImageOptions.Image")));
            this.btnGhiKho.Name = "btnGhiKho";
            this.btnGhiKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiKho_ItemClick);
            // 
            // btnXoaKho
            // 
            this.btnXoaKho.Caption = "Xóa";
            this.btnXoaKho.Id = 3;
            this.btnXoaKho.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Delete_2_icon_24;
            this.btnXoaKho.Name = "btnXoaKho";
            this.btnXoaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaKho_ItemClick);
            // 
            // btnUndoKho
            // 
            this.btnUndoKho.Caption = "Phục hồi";
            this.btnUndoKho.Id = 4;
            this.btnUndoKho.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Undo_icon_24;
            this.btnUndoKho.Name = "btnUndoKho";
            this.btnUndoKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoKho_ItemClick);
            // 
            // btnRefreshKho
            // 
            this.btnRefreshKho.Caption = "Tải lại";
            this.btnRefreshKho.Id = 5;
            this.btnRefreshKho.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Button_Refresh_icon_24;
            this.btnRefreshKho.Name = "btnRefreshKho";
            this.btnRefreshKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshKho_ItemClick);
            // 
            // btnThoatKho
            // 
            this.btnThoatKho.Caption = "Thoát";
            this.btnThoatKho.Id = 6;
            this.btnThoatKho.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Exit_24_icon;
            this.btnThoatKho.Name = "btnThoatKho";
            this.btnThoatKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatKho_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1000, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 590);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1000, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 531);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1000, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
            // 
            // gbChinhanh
            // 
            this.gbChinhanh.Controls.Add(tENCNLabel);
            this.gbChinhanh.Controls.Add(this.cmbChinhanh);
            this.gbChinhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbChinhanh.Location = new System.Drawing.Point(0, 59);
            this.gbChinhanh.Name = "gbChinhanh";
            this.gbChinhanh.Size = new System.Drawing.Size(1000, 89);
            this.gbChinhanh.TabIndex = 4;
            this.gbChinhanh.TabStop = false;
            this.gbChinhanh.Text = "Chi Nhánh";
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.dS_DSPM;
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
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(204, 30);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(93, 21);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi Nhánh:";
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENCN", true));
            this.cmbChinhanh.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cmbChinhanh.DisplayMember = "TENCN";
            this.cmbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(303, 27);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(494, 28);
            this.cmbChinhanh.TabIndex = 1;
            this.cmbChinhanh.ValueMember = "TENSERVER";
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.dS;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiNhanhTableAdapter = null;
            this.tableAdapterManager1.CTDDHTableAdapter = null;
            this.tableAdapterManager1.CTPNTableAdapter = null;
            this.tableAdapterManager1.CTPXTableAdapter = null;
            this.tableAdapterManager1.DatHangTableAdapter = null;
            this.tableAdapterManager1.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager1.NhanVienTableAdapter = null;
            this.tableAdapterManager1.PhieuNhapTableAdapter = null;
            this.tableAdapterManager1.PhieuXuatTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLVT_D15CP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VattuTableAdapter = null;
            // 
            // gcKho
            // 
            this.gcKho.DataSource = this.bdsKho;
            this.gcKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKho.Location = new System.Drawing.Point(0, 148);
            this.gcKho.MainView = this.gridView1;
            this.gcKho.MenuManager = this.barManager1;
            this.gcKho.Name = "gcKho";
            this.gcKho.Size = new System.Drawing.Size(1000, 252);
            this.gcKho.TabIndex = 5;
            this.gcKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gridView1.GridControl = this.gcKho;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.OptionsColumn.AllowEdit = false;
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã Chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // gbCTKho
            // 
            this.gbCTKho.Controls.Add(this.lbThongbaoKho);
            this.gbCTKho.Controls.Add(this.label1);
            this.gbCTKho.Controls.Add(mACNLabel);
            this.gbCTKho.Controls.Add(this.txtMACN);
            this.gbCTKho.Controls.Add(dIACHILabel);
            this.gbCTKho.Controls.Add(this.txtDIACHI);
            this.gbCTKho.Controls.Add(tENKHOLabel);
            this.gbCTKho.Controls.Add(this.txtTENKHO);
            this.gbCTKho.Controls.Add(mAKHOLabel);
            this.gbCTKho.Controls.Add(this.txtMAKHO);
            this.gbCTKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCTKho.Location = new System.Drawing.Point(0, 400);
            this.gbCTKho.Name = "gbCTKho";
            this.gbCTKho.Size = new System.Drawing.Size(1000, 215);
            this.gbCTKho.TabIndex = 7;
            this.gbCTKho.TabStop = false;
            this.gbCTKho.Text = "Chi tiết Kho";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(141, 30);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(71, 21);
            mAKHOLabel.TabIndex = 0;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "MAKHO", true));
            this.txtMAKHO.Location = new System.Drawing.Point(266, 27);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(154, 28);
            this.txtMAKHO.TabIndex = 1;
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(458, 30);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(76, 21);
            tENKHOLabel.TabIndex = 2;
            tENKHOLabel.Text = "Tên kho:";
            // 
            // txtTENKHO
            // 
            this.txtTENKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "TENKHO", true));
            this.txtTENKHO.Location = new System.Drawing.Point(554, 27);
            this.txtTENKHO.Name = "txtTENKHO";
            this.txtTENKHO.Size = new System.Drawing.Size(268, 28);
            this.txtTENKHO.TabIndex = 3;
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(141, 134);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(69, 21);
            dIACHILabel.TabIndex = 4;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(266, 131);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(556, 28);
            this.txtDIACHI.TabIndex = 5;
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(141, 82);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(114, 21);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "Mã chi nhánh:";
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "MACN", true));
            this.txtMACN.Location = new System.Drawing.Point(266, 79);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(154, 28);
            this.txtMACN.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thông báo:";
            // 
            // lbThongbaoKho
            // 
            this.lbThongbaoKho.AutoSize = true;
            this.lbThongbaoKho.Location = new System.Drawing.Point(266, 185);
            this.lbThongbaoKho.Name = "lbThongbaoKho";
            this.lbThongbaoKho.Size = new System.Drawing.Size(0, 21);
            this.lbThongbaoKho.TabIndex = 9;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 615);
            this.Controls.Add(this.gbCTKho);
            this.Controls.Add(this.gcKho);
            this.Controls.Add(this.gbChinhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKho";
            this.Text = "Quản lí Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.gbChinhanh.ResumeLayout(false);
            this.gbChinhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbCTKho.ResumeLayout(false);
            this.gbCTKho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemKho;
        private DevExpress.XtraBars.BarButtonItem btnSuaKho;
        private DevExpress.XtraBars.BarButtonItem btnGhiKho;
        private DevExpress.XtraBars.BarButtonItem btnXoaKho;
        private DevExpress.XtraBars.BarButtonItem btnUndoKho;
        private DevExpress.XtraBars.BarButtonItem btnRefreshKho;
        private DevExpress.XtraBars.BarButtonItem btnThoatKho;
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
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl gcKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.GroupBox gbCTKho;
        private System.Windows.Forms.TextBox txtMACN;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtTENKHO;
        private System.Windows.Forms.TextBox txtMAKHO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbThongbaoKho;
    }
}
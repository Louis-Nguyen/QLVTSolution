namespace QLVT_D15CP
{
    partial class frmCTPX
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAVTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTPX));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLapPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatPX = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gbPX = new System.Windows.Forms.GroupBox();
            this.txtMANVPX = new System.Windows.Forms.TextBox();
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLVT_D15CP.DS();
            this.cmbKHO = new System.Windows.Forms.ComboBox();
            this.txtHOTENKH = new System.Windows.Forms.TextBox();
            this.txtNGAYPX = new DevExpress.XtraEditors.DateEdit();
            this.txtMAPX = new System.Windows.Forms.TextBox();
            this.phieuXuatTableAdapter = new QLVT_D15CP.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT_D15CP.DSTableAdapters.TableAdapterManager();
            this.cTPXTableAdapter = new QLVT_D15CP.DSTableAdapters.CTPXTableAdapter();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCTPN = new System.Windows.Forms.GroupBox();
            this.btnUpdateCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.cmbVattu = new System.Windows.Forms.ComboBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.cTPXDataGridView = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTiens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.gbPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPX.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            this.gbCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(46, 44);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(119, 21);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "Mã phiếu xuất:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(46, 103);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(89, 21);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày xuất:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(393, 44);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(102, 21);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "Khách hàng:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(408, 103);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(88, 21);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Nhân viên:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(751, 103);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(46, 21);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Kho:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(83, 129);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(82, 21);
            sOLUONGLabel.TabIndex = 2;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(83, 189);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(73, 21);
            dONGIALabel.TabIndex = 4;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(81, 70);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(85, 21);
            mAVTLabel.TabIndex = 5;
            mAVTLabel.Text = "Mã vật tư:";
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
            this.btnLapPX,
            this.btnThoatPX});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLapPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnLapPX
            // 
            this.btnLapPX.Caption = "Lập Phiếu Xuất";
            this.btnLapPX.Id = 0;
            this.btnLapPX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPX.ImageOptions.Image")));
            this.btnLapPX.Name = "btnLapPX";
            this.btnLapPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapPX_ItemClick);
            // 
            // btnThoatPX
            // 
            this.btnThoatPX.Caption = "Thoát";
            this.btnThoatPX.Id = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1114, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 572);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1114, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 513);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1114, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 513);
            // 
            // gbPX
            // 
            this.gbPX.Controls.Add(this.txtMANVPX);
            this.gbPX.Controls.Add(this.cmbKHO);
            this.gbPX.Controls.Add(mAKHOLabel);
            this.gbPX.Controls.Add(mANVLabel);
            this.gbPX.Controls.Add(hOTENKHLabel);
            this.gbPX.Controls.Add(this.txtHOTENKH);
            this.gbPX.Controls.Add(nGAYLabel);
            this.gbPX.Controls.Add(this.txtNGAYPX);
            this.gbPX.Controls.Add(mAPXLabel);
            this.gbPX.Controls.Add(this.txtMAPX);
            this.gbPX.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPX.Location = new System.Drawing.Point(0, 59);
            this.gbPX.Name = "gbPX";
            this.gbPX.Size = new System.Drawing.Size(1114, 162);
            this.gbPX.TabIndex = 4;
            this.gbPX.TabStop = false;
            this.gbPX.Text = "Thông tin phiếu xuất";
            // 
            // txtMANVPX
            // 
            this.txtMANVPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MANV", true));
            this.txtMANVPX.Enabled = false;
            this.txtMANVPX.Location = new System.Drawing.Point(502, 100);
            this.txtMANVPX.Name = "txtMANVPX";
            this.txtMANVPX.Size = new System.Drawing.Size(156, 28);
            this.txtMANVPX.TabIndex = 11;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "PhieuXuat";
            this.bdsPX.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKHO
            // 
            this.cmbKHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKHO.FormattingEnabled = true;
            this.cmbKHO.Location = new System.Drawing.Point(803, 100);
            this.cmbKHO.Name = "cmbKHO";
            this.cmbKHO.Size = new System.Drawing.Size(203, 28);
            this.cmbKHO.TabIndex = 10;
            // 
            // txtHOTENKH
            // 
            this.txtHOTENKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "HOTENKH", true));
            this.txtHOTENKH.Location = new System.Drawing.Point(502, 41);
            this.txtHOTENKH.Name = "txtHOTENKH";
            this.txtHOTENKH.Size = new System.Drawing.Size(504, 28);
            this.txtHOTENKH.TabIndex = 5;
            // 
            // txtNGAYPX
            // 
            this.txtNGAYPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "NGAY", true));
            this.txtNGAYPX.EditValue = null;
            this.txtNGAYPX.Enabled = false;
            this.txtNGAYPX.Location = new System.Drawing.Point(171, 103);
            this.txtNGAYPX.MenuManager = this.barManager1;
            this.txtNGAYPX.Name = "txtNGAYPX";
            this.txtNGAYPX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYPX.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYPX.Size = new System.Drawing.Size(141, 22);
            this.txtNGAYPX.TabIndex = 3;
            // 
            // txtMAPX
            // 
            this.txtMAPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAPX", true));
            this.txtMAPX.Location = new System.Drawing.Point(171, 41);
            this.txtMAPX.Name = "txtMAPX";
            this.txtMAPX.Size = new System.Drawing.Size(141, 28);
            this.txtMAPX.TabIndex = 1;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT_D15CP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_PX";
            this.bdsCTPX.DataSource = this.bdsPX;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(356, 527);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(172, 28);
            this.txtTongTien.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "VND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tổng tiền:";
            // 
            // gbCTPN
            // 
            this.gbCTPN.Controls.Add(this.btnUpdateCT);
            this.gbCTPN.Controls.Add(this.btnXoaCT);
            this.gbCTPN.Controls.Add(this.btnThemCT);
            this.gbCTPN.Controls.Add(mAVTLabel);
            this.gbCTPN.Controls.Add(this.cmbVattu);
            this.gbCTPN.Controls.Add(dONGIALabel);
            this.gbCTPN.Controls.Add(this.txtDG);
            this.gbCTPN.Controls.Add(sOLUONGLabel);
            this.gbCTPN.Controls.Add(this.txtSL);
            this.gbCTPN.Location = new System.Drawing.Point(584, 221);
            this.gbCTPN.Name = "gbCTPN";
            this.gbCTPN.Size = new System.Drawing.Size(530, 351);
            this.gbCTPN.TabIndex = 13;
            this.gbCTPN.TabStop = false;
            this.gbCTPN.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // btnUpdateCT
            // 
            this.btnUpdateCT.Image = global::QLVT_D15CP.Properties.Resources.Check_icon241;
            this.btnUpdateCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCT.Location = new System.Drawing.Point(219, 258);
            this.btnUpdateCT.Name = "btnUpdateCT";
            this.btnUpdateCT.Size = new System.Drawing.Size(109, 52);
            this.btnUpdateCT.TabIndex = 11;
            this.btnUpdateCT.Text = "Cập nhật";
            this.btnUpdateCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCT.UseVisualStyleBackColor = true;
            this.btnUpdateCT.Click += new System.EventHandler(this.btnUpdateCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Image = global::QLVT_D15CP.Properties.Resources.Delete_2_icon_242;
            this.btnXoaCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCT.Location = new System.Drawing.Point(382, 258);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(97, 52);
            this.btnXoaCT.TabIndex = 10;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Image = global::QLVT_D15CP.Properties.Resources.Button_Add_24_icon1;
            this.btnThemCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCT.Location = new System.Drawing.Point(62, 258);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(97, 52);
            this.btnThemCT.TabIndex = 9;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // cmbVattu
            // 
            this.cmbVattu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "MAVT", true));
            this.cmbVattu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVattu.FormattingEnabled = true;
            this.cmbVattu.Location = new System.Drawing.Point(171, 67);
            this.cmbVattu.Name = "cmbVattu";
            this.cmbVattu.Size = new System.Drawing.Size(236, 28);
            this.cmbVattu.TabIndex = 6;
            this.cmbVattu.SelectedIndexChanged += new System.EventHandler(this.cmbVattu_SelectedIndexChanged);
            // 
            // txtDG
            // 
            this.txtDG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "DONGIA", true));
            this.txtDG.Location = new System.Drawing.Point(171, 186);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(236, 28);
            this.txtDG.TabIndex = 5;
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "SOLUONG", true));
            this.txtSL.Location = new System.Drawing.Point(171, 126);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(236, 28);
            this.txtSL.TabIndex = 3;
            // 
            // cTPXDataGridView
            // 
            this.cTPXDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTPXDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenVatTu,
            this.SoLuong,
            this.DonGia,
            this.ThanhTiens});
            this.cTPXDataGridView.Location = new System.Drawing.Point(0, 221);
            this.cTPXDataGridView.Name = "cTPXDataGridView";
            this.cTPXDataGridView.Size = new System.Drawing.Size(579, 300);
            this.cTPXDataGridView.TabIndex = 18;
            this.cTPXDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cTPXDataGridView_CellContentClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "Mã vật tư";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // TenVatTu
            // 
            this.TenVatTu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenVatTu.HeaderText = "Tên Vật tư";
            this.TenVatTu.Name = "TenVatTu";
            this.TenVatTu.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTiens
            // 
            this.ThanhTiens.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTiens.HeaderText = "Thành tiền";
            this.ThanhTiens.Name = "ThanhTiens";
            // 
            // frmCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 572);
            this.Controls.Add(this.cTPXDataGridView);
            this.Controls.Add(this.gbCTPN);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPX);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCTPX";
            this.Text = "Chi tiết phiếu xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCTPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.gbPX.ResumeLayout(false);
            this.gbPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPX.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            this.gbCTPN.ResumeLayout(false);
            this.gbCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnLapPX;
        private DevExpress.XtraBars.BarButtonItem btnThoatPX;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox gbPX;
        private System.Windows.Forms.BindingSource bdsPX;
        private DS dS;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtHOTENKH;
        private DevExpress.XtraEditors.DateEdit txtNGAYPX;
        private System.Windows.Forms.TextBox txtMAPX;
        private System.Windows.Forms.ComboBox cmbKHO;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCTPN;
        private System.Windows.Forms.ComboBox cmbVattu;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Button btnUpdateCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.TextBox txtMANVPX;
        private System.Windows.Forms.DataGridView cTPXDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTiens;
    }
}
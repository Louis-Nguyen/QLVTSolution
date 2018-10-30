namespace QLVT_D15CP
{
    partial class frmCTDDH
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTDDH));
            this.dS = new QLVT_D15CP.DS();
            this.bdsDDH = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT_D15CP.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT_D15CP.DSTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVT_D15CP.DSTableAdapters.CTDDHTableAdapter();
            this.gbDDH = new System.Windows.Forms.GroupBox();
            this.txtMANVCT = new System.Windows.Forms.TextBox();
            this.cmbMAKHO = new System.Windows.Forms.ComboBox();
            this.txtNHACCCT = new System.Windows.Forms.TextBox();
            this.txtNGAYCT = new DevExpress.XtraEditors.DateEdit();
            this.txtMSDDHCT = new System.Windows.Forms.TextBox();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLapDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatCTDDH = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCTDDH = new System.Windows.Forms.GroupBox();
            this.btnUpdateCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.cmbVattu = new System.Windows.Forms.ComboBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tblChiTietDDH = new System.Windows.Forms.DataGridView();
            this.phieuNhapTableAdapter = new QLVT_D15CP.DSTableAdapters.PhieuNhapTableAdapter();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
            this.gbDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYCT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            this.gbCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(134, 67);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(105, 21);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(160, 127);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(53, 21);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(441, 127);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(117, 21);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà cung cấp:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(808, 67);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(46, 21);
            mAKHOLabel.TabIndex = 6;
            mAKHOLabel.Text = "Kho:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(441, 67);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(115, 21);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "Nhân viên lập:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(113, 127);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(82, 21);
            sOLUONGLabel.TabIndex = 1;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(113, 186);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(73, 21);
            dONGIALabel.TabIndex = 3;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDDH
            // 
            this.bdsDDH.DataMember = "DatHang";
            this.bdsDDH.DataSource = this.dS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_D15CP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // gbDDH
            // 
            this.gbDDH.Controls.Add(this.txtMANVCT);
            this.gbDDH.Controls.Add(this.cmbMAKHO);
            this.gbDDH.Controls.Add(mANVLabel);
            this.gbDDH.Controls.Add(mAKHOLabel);
            this.gbDDH.Controls.Add(nhaCCLabel);
            this.gbDDH.Controls.Add(this.txtNHACCCT);
            this.gbDDH.Controls.Add(nGAYLabel);
            this.gbDDH.Controls.Add(this.txtNGAYCT);
            this.gbDDH.Controls.Add(masoDDHLabel);
            this.gbDDH.Controls.Add(this.txtMSDDHCT);
            this.gbDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDDH.Location = new System.Drawing.Point(0, 59);
            this.gbDDH.Margin = new System.Windows.Forms.Padding(4);
            this.gbDDH.Name = "gbDDH";
            this.gbDDH.Padding = new System.Windows.Forms.Padding(4);
            this.gbDDH.Size = new System.Drawing.Size(1730, 221);
            this.gbDDH.TabIndex = 0;
            this.gbDDH.TabStop = false;
            this.gbDDH.Text = "Thông tin đơn đặt hàng";
            // 
            // txtMANVCT
            // 
            this.txtMANVCT.Location = new System.Drawing.Point(564, 64);
            this.txtMANVCT.Name = "txtMANVCT";
            this.txtMANVCT.Size = new System.Drawing.Size(168, 28);
            this.txtMANVCT.TabIndex = 11;
            // 
            // cmbMAKHO
            // 
            this.cmbMAKHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAKHO.FormattingEnabled = true;
            this.cmbMAKHO.Location = new System.Drawing.Point(860, 64);
            this.cmbMAKHO.Name = "cmbMAKHO";
            this.cmbMAKHO.Size = new System.Drawing.Size(218, 28);
            this.cmbMAKHO.TabIndex = 10;
            this.cmbMAKHO.SelectedIndexChanged += new System.EventHandler(this.cmbMAKHO_SelectedIndexChanged);
            // 
            // txtNHACCCT
            // 
            this.txtNHACCCT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDDH, "NhaCC", true));
            this.txtNHACCCT.Location = new System.Drawing.Point(564, 124);
            this.txtNHACCCT.Name = "txtNHACCCT";
            this.txtNHACCCT.Size = new System.Drawing.Size(514, 28);
            this.txtNHACCCT.TabIndex = 5;
            // 
            // txtNGAYCT
            // 
            this.txtNGAYCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "NGAY", true));
            this.txtNGAYCT.EditValue = null;
            this.txtNGAYCT.Enabled = false;
            this.txtNGAYCT.Location = new System.Drawing.Point(245, 127);
            this.txtNGAYCT.Name = "txtNGAYCT";
            this.txtNGAYCT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYCT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYCT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtNGAYCT.Size = new System.Drawing.Size(139, 22);
            this.txtNGAYCT.TabIndex = 3;
            // 
            // txtMSDDHCT
            // 
            this.txtMSDDHCT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDDH, "MasoDDH", true));
            this.txtMSDDHCT.Location = new System.Drawing.Point(245, 64);
            this.txtMSDDHCT.Name = "txtMSDDHCT";
            this.txtMSDDHCT.Size = new System.Drawing.Size(139, 28);
            this.txtMSDDHCT.TabIndex = 1;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "CTDDH";
            this.bdsCTDDH.DataSource = this.dS;
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
            this.btnLapDDH,
            this.btnThoatCTDDH});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLapDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatCTDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnLapDDH
            // 
            this.btnLapDDH.Caption = "Lập đơn đặt hàng";
            this.btnLapDDH.Id = 0;
            this.btnLapDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapDDH.ImageOptions.Image")));
            this.btnLapDDH.Name = "btnLapDDH";
            this.btnLapDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapDDH_ItemClick);
            // 
            // btnThoatCTDDH
            // 
            this.btnThoatCTDDH.Caption = "Thoát";
            this.btnThoatCTDDH.Id = 1;
            this.btnThoatCTDDH.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Exit_24_icon;
            this.btnThoatCTDDH.Name = "btnThoatCTDDH";
            this.btnThoatCTDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatCTDDH_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1730, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 691);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1730, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 632);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1730, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 632);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "FK_CTDDH_DatHang";
            this.cTDDHBindingSource.DataSource = this.bdsDDH;
            // 
            // gbCTDDH
            // 
            this.gbCTDDH.Controls.Add(this.btnUpdateCT);
            this.gbCTDDH.Controls.Add(this.btnXoaCT);
            this.gbCTDDH.Controls.Add(this.btnThemCT);
            this.gbCTDDH.Controls.Add(this.cmbVattu);
            this.gbCTDDH.Controls.Add(dONGIALabel);
            this.gbCTDDH.Controls.Add(this.txtDG);
            this.gbCTDDH.Controls.Add(sOLUONGLabel);
            this.gbCTDDH.Controls.Add(this.txtSL);
            this.gbCTDDH.Controls.Add(this.label1);
            this.gbCTDDH.Location = new System.Drawing.Point(557, 280);
            this.gbCTDDH.Name = "gbCTDDH";
            this.gbCTDDH.Size = new System.Drawing.Size(1173, 411);
            this.gbCTDDH.TabIndex = 7;
            this.gbCTDDH.TabStop = false;
            this.gbCTDDH.Text = "Thêm chi tiết đơn đặt hàng";
            // 
            // btnUpdateCT
            // 
            this.btnUpdateCT.Image = global::QLVT_D15CP.Properties.Resources.Check_icon241;
            this.btnUpdateCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCT.Location = new System.Drawing.Point(250, 284);
            this.btnUpdateCT.Name = "btnUpdateCT";
            this.btnUpdateCT.Size = new System.Drawing.Size(109, 52);
            this.btnUpdateCT.TabIndex = 8;
            this.btnUpdateCT.Text = "Cập nhật";
            this.btnUpdateCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCT.UseVisualStyleBackColor = true;
            this.btnUpdateCT.Click += new System.EventHandler(this.btnUpdateCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Image = global::QLVT_D15CP.Properties.Resources.Delete_2_icon_242;
            this.btnXoaCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCT.Location = new System.Drawing.Point(409, 284);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(97, 52);
            this.btnXoaCT.TabIndex = 7;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Image = global::QLVT_D15CP.Properties.Resources.Button_Add_24_icon1;
            this.btnThemCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCT.Location = new System.Drawing.Point(89, 284);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(97, 52);
            this.btnThemCT.TabIndex = 6;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // cmbVattu
            // 
            this.cmbVattu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVattu.FormattingEnabled = true;
            this.cmbVattu.Location = new System.Drawing.Point(204, 59);
            this.cmbVattu.Name = "cmbVattu";
            this.cmbVattu.Size = new System.Drawing.Size(277, 28);
            this.cmbVattu.TabIndex = 5;
            this.cmbVattu.SelectedIndexChanged += new System.EventHandler(this.cmbVattu_SelectedIndexChanged);
            // 
            // txtDG
            // 
            this.txtDG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTDDHBindingSource, "DONGIA", true));
            this.txtDG.Location = new System.Drawing.Point(204, 179);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(277, 28);
            this.txtDG.TabIndex = 4;
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTDDHBindingSource, "SOLUONG", true));
            this.txtSL.Location = new System.Drawing.Point(204, 120);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(277, 28);
            this.txtSL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vật tư:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tổng tiền:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(321, 601);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(174, 28);
            this.txtTongtien.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "VND";
            // 
            // tblChiTietDDH
            // 
            this.tblChiTietDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblChiTietDDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenVatTu,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.tblChiTietDDH.Location = new System.Drawing.Point(0, 280);
            this.tblChiTietDDH.Name = "tblChiTietDDH";
            this.tblChiTietDDH.Size = new System.Drawing.Size(558, 315);
            this.tblChiTietDDH.TabIndex = 15;
            this.tblChiTietDDH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblChiTietDDH_CellContentClick);
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
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
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // frmCTDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 691);
            this.Controls.Add(this.tblChiTietDDH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbCTDDH);
            this.Controls.Add(this.gbDDH);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCTDDH";
            this.Text = "Chi tiết đơn đặt hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCTDDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).EndInit();
            this.gbDDH.ResumeLayout(false);
            this.gbDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYCT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            this.gbCTDDH.ResumeLayout(false);
            this.gbCTDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bdsDDH;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbDDH;
        private System.Windows.Forms.TextBox txtNHACCCT;
        private DevExpress.XtraEditors.DateEdit txtNGAYCT;
        private System.Windows.Forms.TextBox txtMSDDHCT;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnLapDDH;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private System.Windows.Forms.ComboBox cmbMAKHO;
        private DevExpress.XtraBars.BarButtonItem btnThoatCTDDH;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private System.Windows.Forms.GroupBox gbCTDDH;
        private System.Windows.Forms.ComboBox cmbVattu;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.DataGridView tblChiTietDDH;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.TextBox txtMANVCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}
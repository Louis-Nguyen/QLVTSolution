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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTDDH));
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label sOLUONGLabel;
            this.dS = new QLVT_D15CP.DS();
            this.bdsDDH = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT_D15CP.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT_D15CP.DSTableAdapters.TableAdapterManager();
            this.gbDDH = new System.Windows.Forms.GroupBox();
            this.txtMSDDHCT = new System.Windows.Forms.TextBox();
            this.txtNGAYCT = new DevExpress.XtraEditors.DateEdit();
            this.txtNHACCCT = new System.Windows.Forms.TextBox();
            this.txtMAKHOCT = new System.Windows.Forms.TextBox();
            this.txtMANVCT = new System.Windows.Forms.TextBox();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT_D15CP.DSTableAdapters.CTDDHTableAdapter();
            this.gcCTDDH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbCTDDH = new System.Windows.Forms.GroupBox();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLapDDH = new DevExpress.XtraBars.BarButtonItem();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.cmbMAKHO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVattu = new System.Windows.Forms.ComboBox();
            this.btnThemVT = new System.Windows.Forms.Button();
            this.btnXoaVT = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnThoatCTDDH = new DevExpress.XtraBars.BarButtonItem();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
            this.gbDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYCT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
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
            // gbDDH
            // 
            this.gbDDH.Controls.Add(this.cmbMAKHO);
            this.gbDDH.Controls.Add(mANVLabel);
            this.gbDDH.Controls.Add(this.txtMANVCT);
            this.gbDDH.Controls.Add(mAKHOLabel);
            this.gbDDH.Controls.Add(this.txtMAKHOCT);
            this.gbDDH.Controls.Add(nhaCCLabel);
            this.gbDDH.Controls.Add(this.txtNHACCCT);
            this.gbDDH.Controls.Add(nGAYLabel);
            this.gbDDH.Controls.Add(this.txtNGAYCT);
            this.gbDDH.Controls.Add(masoDDHLabel);
            this.gbDDH.Controls.Add(this.txtMSDDHCT);
            this.gbDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDDH.Location = new System.Drawing.Point(0, 59);
            this.gbDDH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDDH.Name = "gbDDH";
            this.gbDDH.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDDH.Size = new System.Drawing.Size(1172, 173);
            this.gbDDH.TabIndex = 0;
            this.gbDDH.TabStop = false;
            this.gbDDH.Text = "Thông tin đơn đặt hàng";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(134, 52);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(105, 21);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // txtMSDDHCT
            // 
            this.txtMSDDHCT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDDH, "MasoDDH", true));
            this.txtMSDDHCT.Location = new System.Drawing.Point(245, 49);
            this.txtMSDDHCT.Name = "txtMSDDHCT";
            this.txtMSDDHCT.Size = new System.Drawing.Size(139, 28);
            this.txtMSDDHCT.TabIndex = 1;
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(160, 112);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(53, 21);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // txtNGAYCT
            // 
            this.txtNGAYCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "NGAY", true));
            this.txtNGAYCT.EditValue = null;
            this.txtNGAYCT.Location = new System.Drawing.Point(245, 112);
            this.txtNGAYCT.Name = "txtNGAYCT";
            this.txtNGAYCT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYCT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYCT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtNGAYCT.Size = new System.Drawing.Size(139, 22);
            this.txtNGAYCT.TabIndex = 3;
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(441, 112);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(117, 21);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà cung cấp:";
            // 
            // txtNHACCCT
            // 
            this.txtNHACCCT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDDH, "NhaCC", true));
            this.txtNHACCCT.Location = new System.Drawing.Point(564, 109);
            this.txtNHACCCT.Name = "txtNHACCCT";
            this.txtNHACCCT.Size = new System.Drawing.Size(514, 28);
            this.txtNHACCCT.TabIndex = 5;
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(758, 52);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(71, 21);
            mAKHOLabel.TabIndex = 6;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // txtMAKHOCT
            // 
            this.txtMAKHOCT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDDH, "MAKHO", true));
            this.txtMAKHOCT.Location = new System.Drawing.Point(984, 52);
            this.txtMAKHOCT.Name = "txtMAKHOCT";
            this.txtMAKHOCT.Size = new System.Drawing.Size(94, 28);
            this.txtMAKHOCT.TabIndex = 7;
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(441, 52);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(113, 21);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // txtMANVCT
            // 
            this.txtMANVCT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDDH, "MANV", true));
            this.txtMANVCT.Location = new System.Drawing.Point(560, 49);
            this.txtMANVCT.Name = "txtMANVCT";
            this.txtMANVCT.Size = new System.Drawing.Size(137, 28);
            this.txtMANVCT.TabIndex = 9;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "CTDDH";
            this.bdsCTDDH.DataSource = this.dS;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // gcCTDDH
            // 
            this.gcCTDDH.DataSource = this.bdsCTDDH;
            this.gcCTDDH.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcCTDDH.Location = new System.Drawing.Point(0, 232);
            this.gcCTDDH.MainView = this.gridView1;
            this.gcCTDDH.Name = "gcCTDDH";
            this.gcCTDDH.Size = new System.Drawing.Size(643, 328);
            this.gcCTDDH.TabIndex = 1;
            this.gcCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView1.GridControl = this.gcCTDDH;
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 1;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 2;
            // 
            // gbCTDDH
            // 
            this.gbCTDDH.Controls.Add(this.btnUpdate);
            this.gbCTDDH.Controls.Add(this.btnXoaVT);
            this.gbCTDDH.Controls.Add(this.btnThemVT);
            this.gbCTDDH.Controls.Add(this.cmbVattu);
            this.gbCTDDH.Controls.Add(this.label1);
            this.gbCTDDH.Controls.Add(sOLUONGLabel);
            this.gbCTDDH.Controls.Add(this.txtSL);
            this.gbCTDDH.Controls.Add(dONGIALabel);
            this.gbCTDDH.Controls.Add(this.txtDG);
            this.gbCTDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCTDDH.Location = new System.Drawing.Point(643, 232);
            this.gbCTDDH.Name = "gbCTDDH";
            this.gbCTDDH.Size = new System.Drawing.Size(529, 346);
            this.gbCTDDH.TabIndex = 2;
            this.gbCTDDH.TabStop = false;
            this.gbCTDDH.Text = "Chi tiết đơn đặt hàng";
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1172, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 560);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1172, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 501);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1172, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 501);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
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
            this.btnLapDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnLapDDH.Name = "btnLapDDH";
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(144, 147);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(73, 21);
            dONGIALabel.TabIndex = 0;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // txtDG
            // 
            this.txtDG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTDDH, "DONGIA", true));
            this.txtDG.Location = new System.Drawing.Point(245, 144);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(153, 28);
            this.txtDG.TabIndex = 1;
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(144, 97);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(82, 21);
            sOLUONGLabel.TabIndex = 2;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTDDH, "SOLUONG", true));
            this.txtSL.Location = new System.Drawing.Point(245, 94);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(153, 28);
            this.txtSL.TabIndex = 3;
            // 
            // cmbMAKHO
            // 
            this.cmbMAKHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAKHO.FormattingEnabled = true;
            this.cmbMAKHO.Location = new System.Drawing.Point(836, 52);
            this.cmbMAKHO.Name = "cmbMAKHO";
            this.cmbMAKHO.Size = new System.Drawing.Size(138, 28);
            this.cmbMAKHO.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã vật tư:";
            // 
            // cmbVattu
            // 
            this.cmbVattu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVattu.FormattingEnabled = true;
            this.cmbVattu.Location = new System.Drawing.Point(245, 42);
            this.cmbVattu.Name = "cmbVattu";
            this.cmbVattu.Size = new System.Drawing.Size(153, 28);
            this.cmbVattu.TabIndex = 5;
            // 
            // btnThemVT
            // 
            this.btnThemVT.Location = new System.Drawing.Point(54, 224);
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(119, 38);
            this.btnThemVT.TabIndex = 6;
            this.btnThemVT.Text = "Thêm";
            this.btnThemVT.UseVisualStyleBackColor = true;
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Location = new System.Drawing.Point(225, 224);
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.Size = new System.Drawing.Size(119, 37);
            this.btnXoaVT.TabIndex = 7;
            this.btnXoaVT.Text = "Xóa";
            this.btnXoaVT.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(390, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnThoatCTDDH
            // 
            this.btnThoatCTDDH.Caption = "Thoát";
            this.btnThoatCTDDH.Id = 1;
            this.btnThoatCTDDH.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Exit_24_icon;
            this.btnThoatCTDDH.Name = "btnThoatCTDDH";
            // 
            // frmCTDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 560);
            this.Controls.Add(this.gbCTDDH);
            this.Controls.Add(this.gcCTDDH);
            this.Controls.Add(this.gbDDH);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbCTDDH.ResumeLayout(false);
            this.gbCTDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bdsDDH;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbDDH;
        private System.Windows.Forms.TextBox txtMANVCT;
        private System.Windows.Forms.TextBox txtMAKHOCT;
        private System.Windows.Forms.TextBox txtNHACCCT;
        private DevExpress.XtraEditors.DateEdit txtNGAYCT;
        private System.Windows.Forms.TextBox txtMSDDHCT;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DevExpress.XtraGrid.GridControl gcCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.GroupBox gbCTDDH;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnLapDDH;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.ComboBox cmbMAKHO;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnXoaVT;
        private System.Windows.Forms.Button btnThemVT;
        private System.Windows.Forms.ComboBox cmbVattu;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnThoatCTDDH;
    }
}
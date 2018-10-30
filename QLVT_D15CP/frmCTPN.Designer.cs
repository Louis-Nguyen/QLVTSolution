namespace QLVT_D15CP
{
    partial class frmCTPN
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTPN));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLapPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gbPN = new System.Windows.Forms.GroupBox();
            this.cmbmaDDH = new System.Windows.Forms.ComboBox();
            this.cmbMAKHO = new System.Windows.Forms.ComboBox();
            this.txtMANVPN = new System.Windows.Forms.TextBox();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLVT_D15CP.DS();
            this.txtNGAYPN = new DevExpress.XtraEditors.DateEdit();
            this.txtMAPN = new System.Windows.Forms.TextBox();
            this.phieuNhapTableAdapter = new QLVT_D15CP.DSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT_D15CP.DSTableAdapters.TableAdapterManager();
            this.cTPNTableAdapter = new QLVT_D15CP.DSTableAdapters.CTPNTableAdapter();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.gbCTPN = new System.Windows.Forms.GroupBox();
            this.cmbVattu = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.tblChiTietPN = new System.Windows.Forms.DataGridView();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.gbPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPN.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            this.gbCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietPN)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(47, 46);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(124, 21);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "Mã phiếu nhập:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(343, 45);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(134, 21);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày nhập hàng:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(741, 45);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(105, 21);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(47, 103);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(165, 21);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = " Nhân viên lập phiếu:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(350, 103);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(127, 21);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Kho nhập hàng:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(127, 118);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(82, 21);
            sOLUONGLabel.TabIndex = 0;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(127, 178);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(73, 21);
            dONGIALabel.TabIndex = 2;
            dONGIALabel.Text = "Đơn giá:";
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
            this.btnLapPN,
            this.btnThoat});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLapPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnLapPN
            // 
            this.btnLapPN.Caption = "Lập phiếu nhập";
            this.btnLapPN.Id = 0;
            this.btnLapPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPN.ImageOptions.Image")));
            this.btnLapPN.Name = "btnLapPN";
            this.btnLapPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapPN_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 1;
            this.btnThoat.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Exit_24_icon;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1127, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 590);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1127, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1127, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
            // 
            // gbPN
            // 
            this.gbPN.Controls.Add(this.cmbmaDDH);
            this.gbPN.Controls.Add(this.cmbMAKHO);
            this.gbPN.Controls.Add(mAKHOLabel);
            this.gbPN.Controls.Add(mANVLabel);
            this.gbPN.Controls.Add(this.txtMANVPN);
            this.gbPN.Controls.Add(masoDDHLabel);
            this.gbPN.Controls.Add(nGAYLabel);
            this.gbPN.Controls.Add(this.txtNGAYPN);
            this.gbPN.Controls.Add(mAPNLabel);
            this.gbPN.Controls.Add(this.txtMAPN);
            this.gbPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPN.Location = new System.Drawing.Point(0, 59);
            this.gbPN.Name = "gbPN";
            this.gbPN.Size = new System.Drawing.Size(1127, 160);
            this.gbPN.TabIndex = 4;
            this.gbPN.TabStop = false;
            this.gbPN.Text = "Thông tin phiếu nhập";
            // 
            // cmbmaDDH
            // 
            this.cmbmaDDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmaDDH.FormattingEnabled = true;
            this.cmbmaDDH.Location = new System.Drawing.Point(852, 43);
            this.cmbmaDDH.Name = "cmbmaDDH";
            this.cmbmaDDH.Size = new System.Drawing.Size(166, 28);
            this.cmbmaDDH.TabIndex = 10;
            this.cmbmaDDH.SelectedIndexChanged += new System.EventHandler(this.cmbmaDDH_SelectedIndexChanged);
            // 
            // cmbMAKHO
            // 
            this.cmbMAKHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAKHO.FormattingEnabled = true;
            this.cmbMAKHO.Location = new System.Drawing.Point(483, 100);
            this.cmbMAKHO.Name = "cmbMAKHO";
            this.cmbMAKHO.Size = new System.Drawing.Size(201, 28);
            this.cmbMAKHO.TabIndex = 9;
            // 
            // txtMANVPN
            // 
            this.txtMANVPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MANV", true));
            this.txtMANVPN.Enabled = false;
            this.txtMANVPN.Location = new System.Drawing.Point(218, 100);
            this.txtMANVPN.Name = "txtMANVPN";
            this.txtMANVPN.Size = new System.Drawing.Size(112, 28);
            this.txtMANVPN.TabIndex = 7;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "PhieuNhap";
            this.bdsPN.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNGAYPN
            // 
            this.txtNGAYPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "NGAY", true));
            this.txtNGAYPN.EditValue = null;
            this.txtNGAYPN.Enabled = false;
            this.txtNGAYPN.Location = new System.Drawing.Point(483, 46);
            this.txtNGAYPN.MenuManager = this.barManager1;
            this.txtNGAYPN.Name = "txtNGAYPN";
            this.txtNGAYPN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYPN.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYPN.Size = new System.Drawing.Size(201, 22);
            this.txtNGAYPN.TabIndex = 3;
            // 
            // txtMAPN
            // 
            this.txtMAPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MAPN", true));
            this.txtMAPN.Location = new System.Drawing.Point(177, 43);
            this.txtMAPN.Name = "txtMAPN";
            this.txtMAPN.Size = new System.Drawing.Size(153, 28);
            this.txtMAPN.TabIndex = 1;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_D15CP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsCTPN.DataSource = this.bdsPN;
            // 
            // gbCTPN
            // 
            this.gbCTPN.Controls.Add(this.cmbVattu);
            this.gbCTPN.Controls.Add(this.btnXoa);
            this.gbCTPN.Controls.Add(this.btnUpdate);
            this.gbCTPN.Controls.Add(this.label3);
            this.gbCTPN.Controls.Add(dONGIALabel);
            this.gbCTPN.Controls.Add(this.txtDG);
            this.gbCTPN.Controls.Add(sOLUONGLabel);
            this.gbCTPN.Controls.Add(this.txtSL);
            this.gbCTPN.Location = new System.Drawing.Point(641, 219);
            this.gbCTPN.Name = "gbCTPN";
            this.gbCTPN.Size = new System.Drawing.Size(486, 370);
            this.gbCTPN.TabIndex = 6;
            this.gbCTPN.TabStop = false;
            this.gbCTPN.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // cmbVattu
            // 
            this.cmbVattu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVattu.Enabled = false;
            this.cmbVattu.FormattingEnabled = true;
            this.cmbVattu.Location = new System.Drawing.Point(215, 53);
            this.cmbVattu.Name = "cmbVattu";
            this.cmbVattu.Size = new System.Drawing.Size(224, 28);
            this.cmbVattu.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLVT_D15CP.Properties.Resources.Delete_2_icon_243;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(330, 248);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 39);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::QLVT_D15CP.Properties.Resources.Check_icon242;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(131, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 39);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã vật tư:";
            // 
            // txtDG
            // 
            this.txtDG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "DONGIA", true));
            this.txtDG.Location = new System.Drawing.Point(215, 175);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(224, 28);
            this.txtDG.TabIndex = 3;
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "SOLUONG", true));
            this.txtSL.Location = new System.Drawing.Point(215, 115);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(224, 28);
            this.txtSL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "VND";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(414, 512);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(172, 28);
            this.txtTongTien.TabIndex = 9;
            // 
            // tblChiTietPN
            // 
            this.tblChiTietPN.AllowUserToAddRows = false;
            this.tblChiTietPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblChiTietPN.Location = new System.Drawing.Point(0, 219);
            this.tblChiTietPN.Name = "tblChiTietPN";
            this.tblChiTietPN.Size = new System.Drawing.Size(639, 287);
            this.tblChiTietPN.TabIndex = 16;
            this.tblChiTietPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblChiTietPN_CellClick);
            // 
            // frmCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 590);
            this.Controls.Add(this.tblChiTietPN);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCTPN);
            this.Controls.Add(this.gbPN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCTPN";
            this.Text = "Chi tiết phiếu nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCTPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.gbPN.ResumeLayout(false);
            this.gbPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPN.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            this.gbCTPN.ResumeLayout(false);
            this.gbCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnLapPN;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox gbPN;
        private System.Windows.Forms.BindingSource bdsPN;
        private DS dS;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMANVPN;
        private DevExpress.XtraEditors.DateEdit txtNGAYPN;
        private System.Windows.Forms.TextBox txtMAPN;
        private System.Windows.Forms.ComboBox cmbMAKHO;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private System.Windows.Forms.GroupBox gbCTPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView tblChiTietPN;
        private System.Windows.Forms.ComboBox cmbmaDDH;
        private System.Windows.Forms.ComboBox cmbVattu;
    }
}
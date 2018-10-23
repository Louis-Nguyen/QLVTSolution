namespace QLVT_D15CP
{
    partial class frmVattu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVattu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatVT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dS = new QLVT_D15CP.DS();
            this.bdsVattu = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT_D15CP.DSTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT_D15CP.DSTableAdapters.TableAdapterManager();
            this.gcVattu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbCTVT = new System.Windows.Forms.GroupBox();
            this.lbThongbaoVT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSLT = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTENVT = new System.Windows.Forms.TextBox();
            this.txtMAVT = new System.Windows.Forms.TextBox();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbCTVT.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(127, 70);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(85, 21);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã vật tư:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(431, 70);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(90, 21);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên vật tư:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(127, 151);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(99, 21);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tính:";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(431, 151);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(111, 21);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "Số lượng tồn:";
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
            this.btnThemVT,
            this.btnSuaVT,
            this.btnGhiVT,
            this.btnXoaVT,
            this.btnUndoVT,
            this.btnRefreshVT,
            this.btnThoatVT});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndoVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefreshVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemVT
            // 
            this.btnThemVT.Caption = "Thêm";
            this.btnThemVT.Id = 0;
            this.btnThemVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemVT_ItemClick);
            // 
            // btnSuaVT
            // 
            this.btnSuaVT.Caption = "Sửa";
            this.btnSuaVT.Id = 1;
            this.btnSuaVT.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Text_Edit_icon_24;
            this.btnSuaVT.Name = "btnSuaVT";
            this.btnSuaVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaVT_ItemClick);
            // 
            // btnGhiVT
            // 
            this.btnGhiVT.Caption = "Ghi";
            this.btnGhiVT.Id = 2;
            this.btnGhiVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.btnGhiVT.Name = "btnGhiVT";
            this.btnGhiVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiVT_ItemClick);
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Caption = "Xóa";
            this.btnXoaVT.Id = 3;
            this.btnXoaVT.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Delete_2_icon_24;
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaVT_ItemClick);
            // 
            // btnUndoVT
            // 
            this.btnUndoVT.Caption = "Phục hồi";
            this.btnUndoVT.Id = 4;
            this.btnUndoVT.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Undo_icon_24;
            this.btnUndoVT.Name = "btnUndoVT";
            this.btnUndoVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoVT_ItemClick);
            // 
            // btnRefreshVT
            // 
            this.btnRefreshVT.Caption = "Tải lại";
            this.btnRefreshVT.Id = 5;
            this.btnRefreshVT.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Button_Refresh_icon_24;
            this.btnRefreshVT.Name = "btnRefreshVT";
            this.btnRefreshVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshVT_ItemClick);
            // 
            // btnThoatVT
            // 
            this.btnThoatVT.Caption = "Thoát";
            this.btnThoatVT.Id = 6;
            this.btnThoatVT.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Exit_24_icon1;
            this.btnThoatVT.Name = "btnThoatVT";
            this.btnThoatVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatVT_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 537);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1000, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 478);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1000, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 478);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVattu
            // 
            this.bdsVattu.DataMember = "Vattu";
            this.bdsVattu.DataSource = this.dS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_D15CP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // gcVattu
            // 
            this.gcVattu.DataSource = this.bdsVattu;
            this.gcVattu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcVattu.Location = new System.Drawing.Point(0, 59);
            this.gcVattu.MainView = this.gridView1;
            this.gcVattu.MenuManager = this.barManager1;
            this.gcVattu.Name = "gcVattu";
            this.gcVattu.Size = new System.Drawing.Size(1000, 228);
            this.gcVattu.TabIndex = 5;
            this.gcVattu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.gcVattu;
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
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.OptionsColumn.AllowEdit = false;
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // gbCTVT
            // 
            this.gbCTVT.Controls.Add(this.lbThongbaoVT);
            this.gbCTVT.Controls.Add(this.label1);
            this.gbCTVT.Controls.Add(sOLUONGTONLabel);
            this.gbCTVT.Controls.Add(this.txtSLT);
            this.gbCTVT.Controls.Add(dVTLabel);
            this.gbCTVT.Controls.Add(this.txtDVT);
            this.gbCTVT.Controls.Add(tENVTLabel);
            this.gbCTVT.Controls.Add(this.txtTENVT);
            this.gbCTVT.Controls.Add(mAVTLabel);
            this.gbCTVT.Controls.Add(this.txtMAVT);
            this.gbCTVT.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCTVT.Location = new System.Drawing.Point(0, 287);
            this.gbCTVT.Name = "gbCTVT";
            this.gbCTVT.Size = new System.Drawing.Size(1000, 283);
            this.gbCTVT.TabIndex = 6;
            this.gbCTVT.TabStop = false;
            this.gbCTVT.Text = "Chi tiết vật tư";
            // 
            // lbThongbaoVT
            // 
            this.lbThongbaoVT.AutoSize = true;
            this.lbThongbaoVT.Location = new System.Drawing.Point(240, 216);
            this.lbThongbaoVT.Name = "lbThongbaoVT";
            this.lbThongbaoVT.Size = new System.Drawing.Size(0, 21);
            this.lbThongbaoVT.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thông báo:";
            // 
            // txtSLT
            // 
            this.txtSLT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVattu, "SOLUONGTON", true));
            this.txtSLT.Location = new System.Drawing.Point(548, 148);
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Size = new System.Drawing.Size(203, 28);
            this.txtSLT.TabIndex = 7;
            // 
            // txtDVT
            // 
            this.txtDVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVattu, "DVT", true));
            this.txtDVT.Location = new System.Drawing.Point(240, 148);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(154, 28);
            this.txtDVT.TabIndex = 5;
            // 
            // txtTENVT
            // 
            this.txtTENVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVattu, "TENVT", true));
            this.txtTENVT.Location = new System.Drawing.Point(548, 67);
            this.txtTENVT.Name = "txtTENVT";
            this.txtTENVT.Size = new System.Drawing.Size(203, 28);
            this.txtTENVT.TabIndex = 3;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVattu, "MAVT", true));
            this.txtMAVT.Location = new System.Drawing.Point(240, 67);
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(154, 28);
            this.txtMAVT.TabIndex = 1;
            // 
            // frmVattu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.gbCTVT);
            this.Controls.Add(this.gcVattu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVattu";
            this.Text = "Quản lí Vật Tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVattu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbCTVT.ResumeLayout(false);
            this.gbCTVT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemVT;
        private DevExpress.XtraBars.BarButtonItem btnSuaVT;
        private DevExpress.XtraBars.BarButtonItem btnGhiVT;
        private DevExpress.XtraBars.BarButtonItem btnXoaVT;
        private DevExpress.XtraBars.BarButtonItem btnUndoVT;
        private DevExpress.XtraBars.BarButtonItem btnRefreshVT;
        private DevExpress.XtraBars.BarButtonItem btnThoatVT;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsVattu;
        private DS dS;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcVattu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox gbCTVT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private System.Windows.Forms.TextBox txtSLT;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTENVT;
        private System.Windows.Forms.TextBox txtMAVT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbThongbaoVT;
    }
}
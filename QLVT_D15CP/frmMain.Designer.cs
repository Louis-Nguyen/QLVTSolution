namespace QLVT_D15CP
{
    partial class frmMain
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnVattu = new DevExpress.XtraBars.BarButtonItem();
            this.btnDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnDX = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.ribDanhmuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribNhanvien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribKho = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribVattu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDDH = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPN = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPX = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribTaoTK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDX = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribThoat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowCustomization = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNhanvien,
            this.btnKho,
            this.btnVattu,
            this.btnDDH,
            this.btnPN,
            this.btnPX,
            this.btnDX,
            this.btnTaoTK,
            this.btnThoat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribDanhmuc});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1263, 179);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Caption = "Nhân viên";
            this.btnNhanvien.Id = 1;
            this.btnNhanvien.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Teacher_male_icon_24;
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanvien_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 2;
            this.btnKho.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Business_Department_24_icon1;
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnVattu
            // 
            this.btnVattu.Caption = "Vật tư";
            this.btnVattu.Id = 3;
            this.btnVattu.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.icons8_big_parcel_641;
            this.btnVattu.Name = "btnVattu";
            this.btnVattu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVattu_ItemClick);
            // 
            // btnDDH
            // 
            this.btnDDH.Caption = "Đơn đặt hàng";
            this.btnDDH.Id = 4;
            this.btnDDH.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.icons8_add_to_collection_641;
            this.btnDDH.Name = "btnDDH";
            this.btnDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDDH_ItemClick);
            // 
            // btnPN
            // 
            this.btnPN.Caption = "Phiếu nhập";
            this.btnPN.Id = 5;
            this.btnPN.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.icons8_shipping_product_641;
            this.btnPN.Name = "btnPN";
            this.btnPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPN_ItemClick);
            // 
            // btnPX
            // 
            this.btnPX.Caption = "Phiếu xuất";
            this.btnPX.Id = 6;
            this.btnPX.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.icons8_file_delivery_641;
            this.btnPX.Name = "btnPX";
            this.btnPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPX_ItemClick);
            // 
            // btnDX
            // 
            this.btnDX.Caption = "Đăng xuất";
            this.btnDX.Id = 7;
            this.btnDX.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.icons8_exit_50;
            this.btnDX.Name = "btnDX";
            this.btnDX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDX_ItemClick);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "Tạo tài khoản";
            this.btnTaoTK.Id = 8;
            this.btnTaoTK.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.icons8_password_64;
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTK_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 9;
            this.btnThoat.ImageOptions.Image = global::QLVT_D15CP.Properties.Resources.Exit_24_icon1;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // ribDanhmuc
            // 
            this.ribDanhmuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribNhanvien,
            this.ribKho,
            this.ribVattu,
            this.ribDDH,
            this.ribPN,
            this.ribPX,
            this.ribTaoTK,
            this.ribDX,
            this.ribThoat});
            this.ribDanhmuc.Name = "ribDanhmuc";
            this.ribDanhmuc.Text = "Danh Mục";
            // 
            // ribNhanvien
            // 
            this.ribNhanvien.ItemLinks.Add(this.btnNhanvien);
            this.ribNhanvien.Name = "ribNhanvien";
            this.ribNhanvien.Text = "                                             ";
            // 
            // ribKho
            // 
            this.ribKho.ItemLinks.Add(this.btnKho);
            this.ribKho.Name = "ribKho";
            this.ribKho.Text = "                                              ";
            // 
            // ribVattu
            // 
            this.ribVattu.ItemLinks.Add(this.btnVattu);
            this.ribVattu.Name = "ribVattu";
            this.ribVattu.Text = "                                              ";
            // 
            // ribDDH
            // 
            this.ribDDH.ItemLinks.Add(this.btnDDH);
            this.ribDDH.Name = "ribDDH";
            // 
            // ribPN
            // 
            this.ribPN.ItemLinks.Add(this.btnPN);
            this.ribPN.Name = "ribPN";
            this.ribPN.Text = "                                                ";
            // 
            // ribPX
            // 
            this.ribPX.ItemLinks.Add(this.btnPX);
            this.ribPX.Name = "ribPX";
            this.ribPX.Text = "                                         ";
            // 
            // ribTaoTK
            // 
            this.ribTaoTK.ItemLinks.Add(this.btnTaoTK);
            this.ribTaoTK.Name = "ribTaoTK";
            this.ribTaoTK.Text = "                                              ";
            // 
            // ribDX
            // 
            this.ribDX.ItemLinks.Add(this.btnDX);
            this.ribDX.Name = "ribDX";
            this.ribDX.Text = "                                            ";
            // 
            // ribThoat
            // 
            this.ribThoat.ItemLinks.Add(this.btnThoat);
            this.ribThoat.Name = "ribThoat";
            this.ribThoat.Text = "                                               ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1263, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(104, 20);
            this.MANV.Text = "Mã nhân viên :";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(61, 20);
            this.HOTEN.Text = "Họ tên :";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(57, 20);
            this.NHOM.Text = "Nhóm :";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lí vật tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribDanhmuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribNhanvien;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribVattu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribDDH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPN;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPX;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribDX;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribTaoTK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribThoat;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public DevExpress.XtraBars.BarButtonItem btnNhanvien;
        public DevExpress.XtraBars.BarButtonItem btnKho;
        public DevExpress.XtraBars.BarButtonItem btnVattu;
        public DevExpress.XtraBars.BarButtonItem btnDDH;
        public DevExpress.XtraBars.BarButtonItem btnPN;
        public DevExpress.XtraBars.BarButtonItem btnPX;
        public DevExpress.XtraBars.BarButtonItem btnTaoTK;
        public DevExpress.XtraBars.BarButtonItem btnDX;
        public DevExpress.XtraBars.BarButtonItem btnThoat;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    }
}


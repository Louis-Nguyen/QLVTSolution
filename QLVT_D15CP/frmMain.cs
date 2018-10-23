using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT_D15CP
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

            //if (Program.mGroup == "USER")
            //{
            //    btnTaoLogin.Enabled = false;
            //    btnTimNV.Enabled = false;
            //    rbbBaoCao.Visible = false;
            //    rbbInDS.Visible = false;
            //}
            //else
            //{
            //    btnTaoLogin.Enabled = true;
            //    btnTimNV.Enabled = true;
            //    rbbBaoCao.Visible = true;
            //    rbbInDS.Visible = true;
            //}
        }

        private void btnNhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null)
            {
                frm.Activate();
                frm.Visible = true;
            }
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKho));
            if (frm != null)
            {
                frm.Activate();
                frm.Visible = true;
            }
            else
            {
                frmKho f = new frmKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnVattu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVattu));
            if (frm != null)
            {
                frm.Activate();
                frm.Visible = true;
            }
            else
            {
                frmVattu f = new frmVattu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDonDatHang));
            if (frm != null)
            {
                frm.Activate();
                frm.Visible = true;
            }
            else
            {
                frmDonDatHang f = new frmDonDatHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuNhap));
            if (frm != null)
            {
                frm.Activate();
                frm.Visible = true;
            }
            else
            {
                frmPhieuNhap f = new frmPhieuNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuXuat));
            if (frm != null)
            {
                frm.Activate();
                frm.Visible = true;
            }
            else
            {
                frmPhieuXuat f = new frmPhieuXuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (MessageBox.Show("BẠN MUỐN ĐĂNG XUẤT?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Dispose();
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
            }
        }
        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTK));
            if (frm != null)
            {
                frm.Activate();
                frm.Visible = true;
            }
            else
            {
                frmTaoTK f = new frmTaoTK();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ MUỐN THOÁT ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.SetVisibleCore(false);
                Application.Exit();
            }
        }
        private void frmMain1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ MUỐN THOÁT ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.SetVisibleCore(false);
                Application.Exit();
            }
            else
            {
                //xử lí khác
            }
        }

      
    }
}

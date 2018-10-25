using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_D15CP
{
    
    public partial class frmDonDatHang : Form
    {
        int vitri = 0;
        string macn = "";
        public frmDonDatHang()
        {
            InitializeComponent();
            gbDDH.Enabled = false;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
           
            dS.EnforceConstraints = false;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.dS.DatHang);
            // TODO: This line of code loads data into the 'dS_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);

            //macn = ((DataRowView)bdsDathang[0])["MACN"].ToString().Trim();
            cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;
                btnThemDDH.Enabled = false;
                btnSuaDDH.Enabled = false;
                btnGhiDDH.Enabled = false;
                btnUndoDDH.Enabled = false;
                btnRefreshDDH.Enabled = false;
                btnCTDDH.Enabled = true;

            } // bật tắt theo phân quyền
            else
            {
                cmbChinhanh.Enabled = false;
                btnThemDDH.Enabled = true;
                btnSuaDDH.Enabled = true;
                btnGhiDDH.Enabled = false;
                btnUndoDDH.Enabled = false;
                btnRefreshDDH.Enabled = true;
                btnCTDDH.Enabled = false;
            }
        }

        private void btnThemDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                frmCTDDH f = new frmCTDDH();
                f.Show();
            
        }

        private void btnThoatDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Visible = false;
        }

       

        private void btnSuaDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDathang.Position;
            gbDDH.Enabled = true;
            txtMASODDH.Enabled = false;
            btnThemDDH.Enabled = btnSuaDDH.Enabled = btnRefreshDDH.Enabled = btnThoatDDH.Enabled = false;
            btnGhiDDH.Enabled = btnUndoDDH.Enabled = true;
            gcDDH.Enabled = false;
            txtMASODDH.Focus();
        }

        private void btnGhiDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAKHO.Text.Trim().Equals(""))
            {
                txtThongbao.Text = "Mã kho không thể để trống.";
                txtMAKHO.Focus();
                return;
            }
            if (txtMANV.Text.Trim().Equals(""))
            {
                txtThongbao.Text = "Tên nhân viên không thể để trống.";
                txtMANV.Focus();
                return;
            }
            if (txtNHACC.Text.Trim().Equals(""))
            {
                txtThongbao.Text = "Nhà cung cấp không thể để trống.";
                txtNHACC.Focus();
                return;
            }
            try
            {

                txtThongbao.Text = "";
                bdsDathang.EndEdit();
                bdsDathang.ResetCurrentItem();
                if (dS.HasChanges())
                {

                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.dS.DatHang);
                }


            }
            catch (Exception exp)
            {
                    MessageBox.Show("Lỗi Ghi kho. Bạn kiểm tra lại thông tin kho trứơc khi ghi.", "Lỗi Kho", MessageBoxButtons.OK);
            }
            gcDDH.Enabled = true;
            gbDDH.Enabled = false;
            btnThemDDH.Enabled = btnSuaDDH.Enabled = btnRefreshDDH.Enabled = btnThoatDDH.Enabled = true;
            btnGhiDDH.Enabled = btnUndoDDH.Enabled = false;
        }

        private void btnUndoDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtThongbao.Text = "";
            bdsDathang.CancelEdit();
            if (btnThemDDH.Enabled == false) bdsDathang.Position = vitri;
            gcDDH.Enabled = true;
            gbDDH.Enabled = false;
            btnThemDDH.Enabled = btnSuaDDH.Enabled = btnRefreshDDH.Enabled = btnThoatDDH.Enabled = true;
            btnGhiDDH.Enabled = btnUndoDDH.Enabled = false;
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cmbChinhanh.SelectedValue.ToString();

                if (cmbChinhanh.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                else
                {
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Fill(this.dS.DatHang);

                   // macn = ((DataRowView)bdsDathang[0])["MACN"].ToString().Trim();
                }
            }
            catch (NullReferenceException exp) { }
        }

        private void btnRefreshDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.datHangTableAdapter.Fill(this.dS.DatHang);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}

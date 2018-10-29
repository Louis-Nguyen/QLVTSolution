using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLVT_D15CP
{
    public partial class frmPhieuNhap : Form
    {
        int vitri = 0;
        string macn = "";
        public frmPhieuNhap()
        {
            InitializeComponent();
            gbPN.Enabled = false;
            gcCTPN.Enabled = false;
        }
        public void LoadDataToComboBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MANV,HOTEN from V_LAYTENNHANVIEN", Program.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMANV.DataSource = dt;
            cmbMANV.ValueMember = "MANV";
            cmbMANV.DisplayMember = "HOTEN";
            //cmbMANV.SelectedValue = txtMANVDDH.Text.Trim();
        }
        public void LoadDataToComboBox2()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MAKHO,TENKHO from V_LAYTENKHO", Program.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMAKHO.DataSource = dt;
            cmbMAKHO.ValueMember = "MAKHO";
            cmbMAKHO.DisplayMember = "TENKHO";
            //cmbMAKHO.SelectedValue = txtMAKHODDH.Text.Trim(); 
        }


        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
           
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            // TODO: This line of code loads data into the 'dS_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            this.LoadDataToComboBox();
            this.LoadDataToComboBox2();
            cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;
                btnThemPN.Enabled = false;
                btnSuaPN.Enabled = false;
                btnGhiPN.Enabled = false;
                btnUndoPN.Enabled = false;
                btnXoaPN.Enabled = false;
                btnRefreshPN.Enabled = false;

            } // bật tắt theo phân quyền
            else
            {
                cmbChinhanh.Enabled = false;
                btnThemPN.Enabled = true;
                btnSuaPN.Enabled = true;
                btnGhiPN.Enabled = false;
                btnUndoPN.Enabled = false;
                btnXoaPN.Enabled = true;
                btnRefreshPN.Enabled = true;
            }
        }

        private void btnThoatPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

                    // macn = ((DataRowView)bdsDathang[0])["MACN"].ToString().Trim();
                }
            }
            catch (NullReferenceException exp) { }
        }

        private void btnThemPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCTPN f = new frmCTPN();
            f.Show();
        }

        private void btnSuaPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsPN.Position;
            gbPN.Enabled = true;
            txtMAPN.Enabled = false;
            btnThemPN.Enabled = btnSuaPN.Enabled = btnXoaPN.Enabled = btnRefreshPN.Enabled = btnThoatPN.Enabled = false;
            btnGhiPN.Enabled = btnUndoPN.Enabled = true;
            gcPN.Enabled = false;
            txtNGAYPN.Focus();
        }

        private void btnUndoPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbThongbao.Text = "";
            bdsPN.CancelEdit();
            if (btnThemPN.Enabled == false) bdsPN.Position = vitri;
            gcPN.Enabled = true;
            gbPN.Enabled = false;
            btnThemPN.Enabled = btnSuaPN.Enabled = btnRefreshPN.Enabled = btnXoaPN.Enabled = btnThoatPN.Enabled = true;
            btnGhiPN.Enabled = btnUndoPN.Enabled = false;
        }

        private void btnRefreshPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnGhiPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                lbThongbao.Text = "";
                bdsPN.EndEdit();
                bdsPN.ResetCurrentItem();
                bdsCTPN.EndEdit();
                bdsCTPN.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPNTableAdapter.Update(this.dS.CTPN);
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.dS.PhieuNhap);
                }


            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi Ghi Phiếu nhập. Bạn kiểm tra lại thông tin phiếu nhập trứơc khi ghi.", "Lỗi Phiếu nhập", MessageBoxButtons.OK);
            }
            gcPN.Enabled = true;
            gbPN.Enabled = false;
            btnThemPN.Enabled = btnSuaPN.Enabled = btnRefreshPN.Enabled = btnXoaPN.Enabled = btnThoatPN.Enabled = true;
            btnGhiPN.Enabled = btnUndoPN.Enabled = false;
        }

        private void btnXoaPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
                string maPN = ((DataRowView)bdsPN[bdsPN.Position])["MAPN"].ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu nhập này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    try
                    {
                        bdsPN.RemoveCurrent();
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuNhapTableAdapter.Update(this.dS.PhieuNhap);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa phiếu nhập. Bạn hãy xóa lại\n" + ex.Message, "",
                            MessageBoxButtons.OK);
                        this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
                        bdsPN.Position = bdsPN.Find("MAPN", maPN);
                        return;
                    }
                }
            
        }

        private void cmbMANV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMANVPN.Text = cmbMANV.SelectedValue.ToString();
        }

        private void cmbMAKHO_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMAKHOPN.Text = cmbMAKHO.SelectedValue.ToString();
        }
    }
}

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
    
    public partial class frmDonDatHang : Form
    {
        int vitri = 0;
        string macn = "";
        public frmDonDatHang()
        {
            InitializeComponent();
            gbDDH.Enabled = false;
            cTDDHDataGridView.Enabled = false;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
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
            this.LoadDataToComboBox();
            this.LoadDataToComboBox2();
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
                btnXoa.Enabled = false;
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
                btnXoa.Enabled = true;
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
            btnThemDDH.Enabled = btnSuaDDH.Enabled = btnRefreshDDH.Enabled = btnThoatDDH.Enabled = btnXoa.Enabled = false;
            btnGhiDDH.Enabled = btnUndoDDH.Enabled = true;
            gcDDH.Enabled = false;
            cTDDHDataGridView.Enabled = true;
            txtNGAY.Focus();
            // kiểm tra đơn đặt hàng có trong phiếu nhập hay k. Nếu là phiếu mới thì cho sửa chi tiết đơn đặt hàng.
            string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_KIEMTRADDHCOTRONGPHIEUNHAP] N'" + txtMASODDH.Text.Trim() + "' SELECT  'Return Value' = @return_value";
            SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);
            if (myreader == null) return;
            myreader.Read();
            int dem = myreader.GetInt32(0);
            myreader.Close();
            if (dem != 0)
            {
                cTDDHDataGridView.Enabled = false;
            }
        }

        private void btnGhiDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMANVDDH.Text = cmbMANV.SelectedValue.ToString();
            txtMAKHODDH.Text = cmbMAKHO.SelectedValue.ToString();
            if (txtNGAY.Text.Trim().Equals(""))
            {
                txtThongbao.Text = "Ngày không thể để trống.";
                txtNGAY.Focus();
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
                bdsCTDDH.EndEdit();
                bdsCTDDH.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTDDHTableAdapter.Update(this.dS.CTDDH);
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.dS.DatHang);
                }


            }
            catch (Exception exp)
            {
                    MessageBox.Show("Lỗi Ghi đơn đặt hàng. Bạn kiểm tra lại thông tin đơn đặt hàng trứơc khi ghi.", "Lỗi Đơn đặt hàng", MessageBoxButtons.OK);
                     return;
            }
            gcDDH.Enabled = true;
            gbDDH.Enabled = false;
            cTDDHDataGridView.Enabled = false;
            btnThemDDH.Enabled = btnSuaDDH.Enabled = btnRefreshDDH.Enabled = btnThoatDDH.Enabled = btnXoa.Enabled = true;
            btnGhiDDH.Enabled = btnUndoDDH.Enabled = false;
        }

        private void btnUndoDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtThongbao.Text = "";
            bdsDathang.CancelEdit();
            if (btnThemDDH.Enabled == false) bdsDathang.Position = vitri;
            gcDDH.Enabled = true;
            gbDDH.Enabled = false;
            cTDDHDataGridView.Enabled = false;
            btnThemDDH.Enabled = btnSuaDDH.Enabled = btnRefreshDDH.Enabled = btnThoatDDH.Enabled = btnXoa.Enabled = true;
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

        private void btnXoaPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_KIEMTRADDHCOTRONGPHIEUNHAP] N'" + txtMASODDH.Text.Trim() + "' SELECT  'Return Value' = @return_value";
            SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);
            if (myreader == null) return;
            myreader.Read();
            int dem = myreader.GetInt32(0);
            myreader.Close();
            if (dem != 0)
            {
                MessageBox.Show("Đơn đặt hàng này đã có trong phiếu nhập. Không thể xóa!", "Lỗi xóa phiếu", MessageBoxButtons.OK);
            }
            else
            {
                string Masoddh = ((DataRowView)bdsDathang[bdsDathang.Position])["MasoDDH"].ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    try
                    {
                        int row = cTDDHDataGridView.Rows.Count;
                        for (int i=0;i< row; i++)
                        {
                            cTDDHDataGridView.Rows.RemoveAt(0);
                        }
                        bdsDathang.RemoveCurrent();
                        if (dS.HasChanges())
                        {
                            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.cTDDHTableAdapter.Update(this.dS.CTDDH);
                            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.datHangTableAdapter.Update(this.dS.DatHang);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa đơn đặt hàng. Bạn hãy xóa lại\n" + ex.Message, "",
                            MessageBoxButtons.OK);
                        this.datHangTableAdapter.Fill(this.dS.DatHang);
                        bdsDathang.Position = bdsDathang.Find("MasoDDH", Masoddh);
                        return;
                    }
                }
            }
        }

        private void cmbMANV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMANVDDH.Text = cmbMANV.SelectedValue.ToString();
        }

        private void cmbMAKHO_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMAKHODDH.Text = cmbMAKHO.SelectedValue.ToString();
        }
    }
}

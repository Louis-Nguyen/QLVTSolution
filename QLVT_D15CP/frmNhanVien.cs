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
using System.Globalization;

namespace QLVT_D15CP
{
    public partial class frmNhanVien : Form
    {
        int vitri = 0;
        string macn = "";
        string supportGhi = "";
        string maNVtemp = "";
        
        public frmNhanVien()
        {
            InitializeComponent();
            gbCTNV.Enabled = false;
        }
       
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            // TODO: This line of code loads data into the 'dS_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);

            macn = ((DataRowView)bdsNhanvien[0])["MACN"].ToString().Trim();
            cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;
                btnThemNV.Enabled = false;
                btnSuaNV.Enabled = false;
                btnGhiNV.Enabled = false;
                btnXoaNV.Enabled = false;
                btnUndoNV.Enabled = false;
                btnRefreshNV.Enabled = false;
                btnCCN.Enabled = false;

            } // bật tắt theo phân quyền
            else
            {
                cmbChinhanh.Enabled = false;
                btnThemNV.Enabled = true;
                btnSuaNV.Enabled = true;
                btnGhiNV.Enabled = false;
                btnXoaNV.Enabled = true;
                btnUndoNV.Enabled = false;
                btnRefreshNV.Enabled = true;
                btnCCN.Enabled = true;
            }

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
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

                    macn = ((DataRowView)bdsNhanvien[0])["MACN"].ToString().Trim();
                }
            }
            catch (NullReferenceException exp) { }
        }

        private void btnThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            //Program.formMain.ribbonControl1.Enabled = false;
            vitri = bdsNhanvien.Position;
            gbCTNV.Enabled = true;
            gcNhanvien.Enabled = false;
            bdsNhanvien.AddNew();
            txtLUONG.Text = "5000000";
            txtTTX.Text = "0";
            txtTTX.Enabled = false;
            txtMACN.Text = macn;
            txtMACN.Enabled = false;
            btnThemNV.Enabled = btnSuaNV.Enabled = btnCCN.Enabled = btnXoaNV.Enabled = btnRefreshNV.Enabled = btnThoatNV.Enabled = false;
            btnGhiNV.Enabled = btnUndoNV.Enabled = true;
            //Event Bar Danh mục
            supportGhi = "them";
            txtMANV.Focus();
        }

        private void btnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Program.formMain.ribbonControl1.Enabled = false;
            if (txtTTX.Text.Trim().Equals("1"))
            {
                MessageBox.Show("Nhân viên đã bị xóa! Không được sửa.", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            txtTTX.Enabled = false;
            txtMACN.Enabled = false;
            vitri = bdsNhanvien.Position;
            gbCTNV.Enabled = true;
            btnThemNV.Enabled = btnSuaNV.Enabled = btnCCN.Enabled = btnXoaNV.Enabled = btnRefreshNV.Enabled = btnThoatNV.Enabled = false;
            btnGhiNV.Enabled = btnUndoNV.Enabled = true;
            gcNhanvien.Enabled = false;
            maNVtemp = txtMANV.Text.Trim();
            supportGhi = "sua";
            txtHO.Focus();
        }

        private void btnThoatNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Visible = false;
        }

        private void btnRefreshNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnGhiNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (int.Parse(txtMANV.Text) <= 0)
            {
                lbThongbao.Text = "Mã nhân viên không thể là số âm hoặc 0.";
                txtMANV.Focus();
                return;
            }
            if (supportGhi.Trim().Equals("them"))
            {
                string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_KIEMTRANHANVIENTONTAI] " + txtMANV.Text.Trim() + " SELECT  'Return Value' = @return_value";
                SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);
                if (myreader == null) return;
                myreader.Read();
                int dem = myreader.GetInt32(0);
                myreader.Close();
                if (dem == 1)
                {
                    MessageBox.Show("Mã nhân viên bị trùng.", "Lỗi thêm nhân viên", MessageBoxButtons.OK);
                    txtMANV.Focus();
                    return;
                }
            }
            if (supportGhi.Trim().Equals("sua")&& txtMANV.Text.Trim().Equals(maNVtemp)==false)
            {
                string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_KIEMTRANHANVIENTONTAI] " + txtMANV.Text.Trim() + " SELECT  'Return Value' = @return_value";
                SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);
                if (myreader == null) return;
                myreader.Read();
                int dem = myreader.GetInt32(0);
                myreader.Close();
                if (dem == 1)
                {
                    MessageBox.Show("Mã nhân viên bị trùng.", "Lỗi sửa nhân viên", MessageBoxButtons.OK);
                    txtMANV.Focus();
                    return;
                }
            }
            if (txtHO.Text.Trim().Equals(""))
            {
                lbThongbao.Text = "Họ nhân viên không thể để trống.";
                txtHO.Focus();
                return;

            }
            if (txtTEN.Text.Trim().Equals(""))
            {
                lbThongbao.Text = "Tên nhân viên không thể để trống.";
                txtTEN.Focus();
                return;
            }
            if (txtLUONG.Text.Trim().Equals(""))
            {
                lbThongbao.Text = "Lương không thể để trống.";
                txtLUONG.Focus();
                return;
            }
            if (Int32.Parse(txtLUONG.Text) < 4000000)
            {
                lbThongbao.Text = "Lương Nhân viên không thể < 4000000 ";
                txtLUONG.Focus();
                return;
            }
            if (txtDIACHI.Text.Trim().Equals(""))
            {
                lbThongbao.Text = "Địa chỉ không thể để trống.";
                txtDIACHI.Focus();
                return;
            }
            try
            {

                lbThongbao.Text = "";
                bdsNhanvien.EndEdit();
                bdsNhanvien.ResetCurrentItem();
                if (dS.HasChanges())
                {

                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                }

                // MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK);

            }
            catch (Exception exp)
            {

                if (exp.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã nhân viên bị trùng.", "Lỗi nhân viên", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Lỗi Ghi nhân viên. Bạn kiểm tra lại thông tin nhân viên trứơc khi ghi.", "Lỗi nhân viên", MessageBoxButtons.OK);
                }
            }
            gcNhanvien.Enabled = true;
            btnThemNV.Enabled = btnSuaNV.Enabled = btnCCN.Enabled = btnXoaNV.Enabled = btnRefreshNV.Enabled = btnThoatNV.Enabled = true;
            btnGhiNV.Enabled = btnUndoNV.Enabled = false;
            gbCTNV.Enabled = false;
            //Program.formMain.ribbonControl1.Enabled = true;
        }

        private void btnUndoNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbThongbao.Text = "";
            bdsNhanvien.CancelEdit();
            if (btnThemNV.Enabled == false) bdsNhanvien.Position = vitri;
            gcNhanvien.Enabled = true;
            gbCTNV.Enabled = false;
            btnThemNV.Enabled = btnSuaNV.Enabled = btnCCN.Enabled = btnXoaNV.Enabled = btnRefreshNV.Enabled = btnThoatNV.Enabled = true;
            btnGhiNV.Enabled = btnUndoNV.Enabled = false;
           // Program.formMain.ribbonControl1.Enabled = true;
        }

        private void btnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[sp_KiemTraNhanVienLapPhieu] " + txtMANV.Text.Trim() + " SELECT  'Return Value' = @return_value";
            SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);
            if (myreader == null) return;
            myreader.Read();
            int dem = myreader.GetInt32(0);
            myreader.Close();
            if (dem != 0)
            {
                MessageBox.Show("Nhân viên đã lập phiếu. Không thể xóa !", "Lỗi xóa nhân viên", MessageBoxButtons.OK);
            }
            else
            {
                int manv = int.Parse(((DataRowView)bdsNhanvien[bdsNhanvien.Position])["MANV"].ToString());
                if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                        
                    try
                    {
                      // int  manv = int.Parse(((DataRowView)bdsNhanvien[bdsNhanvien.Position])["MANV"].ToString()); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                        bdsNhanvien.RemoveCurrent();
                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                            MessageBoxButtons.OK);
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                            bdsNhanvien.Position = bdsNhanvien.Find("MANV", manv);
                        return;
                    }
                }
            }
        }

        private void btnCCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string TempHO = txtHO.Text.Trim();
            string TempTEN = txtTEN.Text.Trim();
            DateTime TempNGAYSINH = txtNGAYSINH.DateTime;
            string TempDIACHI = txtDIACHI.Text.Trim();
            int TempLUONG = int.Parse(txtLUONG.Text.Trim());
            string TempCN = "";
            int MaNVRandom=0;
            // Kiểm tra nhân viên đã xóa .Xóa rồi thì không thể chuyển chi nhánh.
            if (txtTTX.Text.Trim().Equals("1"))
            {
                MessageBox.Show("Nhân viên đã bị xóa! Không thể chuyển chi nhánh.", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            // Kiểm tra nhân viên đã từng lập phiếu.

            string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[sp_KiemTraNhanVienLapPhieu] " + txtMANV.Text.Trim() + " SELECT  'Return Value' = @return_value";
            SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);
            if (myreader == null) return;
            myreader.Read();
            int dem = myreader.GetInt32(0);
            myreader.Close();
            if (dem != 0)
            {
                txtTTX.Text = "1";
                bdsNhanvien.EndEdit();
                bdsNhanvien.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
            }
            else
            {
                    int manv = int.Parse(((DataRowView)bdsNhanvien[bdsNhanvien.Position])["MANV"].ToString());
                    try
                    {
                        // int  manv = int.Parse(((DataRowView)bdsNhanvien[bdsNhanvien.Position])["MANV"].ToString()); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                        bdsNhanvien.RemoveCurrent();
                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "Lỗi chuyển chi nhánh nhân viên",
                            MessageBoxButtons.OK);
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                        bdsNhanvien.Position = bdsNhanvien.Find("MANV", manv);
                        return;
                    }
                
            }
            //===================================
            // Thay đổi mã chi nhánh 
            if (txtMACN.Text.Trim().Equals("CN1"))
            {
                TempCN = "CN2";
            }
            else if (txtMACN.Text.Trim().Equals("CN2"))
            {
                TempCN = "CN1";
            }
            else
            {
                return;
            }
            // Random mã nhân viên mới và kiểm tra mã mới đã tồn tại hay chưa.
            Boolean check = true;
            while (check==true)
            {
                Random ran = new Random();
                MaNVRandom = ran.Next(1, 100);
                string strLenhKiemTra = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_KIEMTRANHANVIENTONTAI] " + MaNVRandom + " SELECT  'Return Value' = @return_value";
                SqlDataReader kiemtra = Program.ExecSqlDataReader(strLenhKiemTra);
                if (kiemtra == null) return;
                kiemtra.Read();
                int count = kiemtra.GetInt32(0);
                kiemtra.Close();
                if (count == 0)
                {
                    check = false;
                }
            }
           
            // thêm nhân viên mới vào site khác.
            try
            {

               //string str = DateTime.Parse(txtNGAYSINH.Text).ToString();
               // DateTime date = DateTime.ParseExact(str, "yyyy-MM-dd", CultureInfo.InvariantCulture);
               // var date = dt.ToString("yyyy-MM-dd");
                string strLenhThemnv = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_TAONHANVIENSITEKHAC] @MANV ="+ MaNVRandom +" , @HO = N'"+TempHO+"', @TEN = N'"+TempTEN+"', @DIACHI = N'"+TempDIACHI+"', @NGAYSINH = " + TempNGAYSINH + " , @LUONG = "+TempLUONG+", @MACN = N'"+TempCN+"' SELECT  'Return Value' = @return_value";
                Program.ExecSqlDataReader(strLenhThemnv);
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
            catch
            {
                MessageBox.Show("Lỗi tạo nhân viên ở chi nhánh mới. Không thể chuyển nhân viên!", "Lỗi chuyển nhân viên", MessageBoxButtons.OK);
                return;
            }


        }
    }
}

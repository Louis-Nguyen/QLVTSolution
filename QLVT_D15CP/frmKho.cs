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
    public partial class frmKho : Form
    {
        int vitri = 0;
        string macn = "";
        string supportGhi = "";
        string maKhotemp = "";
        public frmKho()
        {
            InitializeComponent();
            gbCTKho.Enabled = false;
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.dS.Kho);
            // TODO: This line of code loads data into the 'dS_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);

            macn = ((DataRowView)bdsKho[0])["MACN"].ToString().Trim();
            cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;
                btnThemKho.Enabled = false;
                btnSuaKho.Enabled = false;
                btnGhiKho.Enabled = false;
                btnXoaKho.Enabled = false;
                btnUndoKho.Enabled = false;
                btnRefreshKho.Enabled = false;

            } // bật tắt theo phân quyền
            else
            {
                cmbChinhanh.Enabled = false;
                btnThemKho.Enabled = true;
                btnSuaKho.Enabled = true;
                btnGhiKho.Enabled = false;
                btnXoaKho.Enabled = true;
                btnUndoKho.Enabled = false;
                btnRefreshKho.Enabled = true;
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
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Fill(this.dS.Kho);

                    macn = ((DataRowView)bdsKho[0])["MACN"].ToString().Trim();
                }
            }
            catch (NullReferenceException exp) { }
        }

        private void btnThemKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            gbCTKho.Enabled = true;
            gcKho.Enabled = false;
            bdsKho.AddNew();
            txtMACN.Text = macn;
            txtMACN.Enabled = false;
            btnThemKho.Enabled = btnXoaKho.Enabled = btnSuaKho.Enabled = btnRefreshKho.Enabled = btnThoatKho.Enabled = false;
            btnGhiKho.Enabled = btnUndoKho.Enabled = true;
            supportGhi = "them";
            txtMAKHO.Focus();
        }

        private void btnSuaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            gbCTKho.Enabled = true;
            gcKho.Enabled = false;
            btnThemKho.Enabled = btnXoaKho.Enabled = btnSuaKho.Enabled = btnRefreshKho.Enabled = btnThoatKho.Enabled = false;
            btnGhiKho.Enabled = btnUndoKho.Enabled = true;
            maKhotemp = txtMAKHO.Text.Trim();
            supportGhi = "sua";
            txtMAKHO.Focus();
        }

        private void btnGhiKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAKHO.Text.Trim().Equals(""))
            {
                lbThongbaoKho.Text = "Mã kho không thể để trống.";
                txtMAKHO.Focus();
                return;

            }
            if (supportGhi.Trim().Equals("them"))
            {
                string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_KIEMTRAKHOTONTAI] N'" + txtMAKHO.Text.Trim() + "' SELECT  'Return Value' = @return_value";
                SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);
                if (myreader == null) return;
                myreader.Read();
                int dem = myreader.GetInt32(0);
                myreader.Close();
                if (dem == 1)
                {
                    MessageBox.Show("Mã kho bị trùng.", "Lỗi thêm kho", MessageBoxButtons.OK);
                    txtMAKHO.Focus();
                    return;
                }
            }
            if (supportGhi.Trim().Equals("sua") && txtMAKHO.Text.Trim().Equals(maKhotemp) == false)
            {
                string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_KIEMTRAKHOTONTAI] N'" + txtMAKHO.Text.Trim() + "' SELECT  'Return Value' = @return_value";
                SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);
                if (myreader == null) return;
                myreader.Read();
                int dem = myreader.GetInt32(0);
                myreader.Close();
                if (dem == 1)
                {
                    MessageBox.Show("Mã kho bị trùng.", "Lỗi sửa kho", MessageBoxButtons.OK);
                    txtMAKHO.Focus();
                    return;
                }
            }
            if (txtTENKHO.Text.Trim().Equals(""))
            {
                lbThongbaoKho.Text = "Tên kho không thể để trống.";
                txtTENKHO.Focus();
                return;
            }
            if (txtDIACHI.Text.Trim().Equals(""))
            {
                lbThongbaoKho.Text = "Địa chỉ không thể để trống.";
                txtDIACHI.Focus();
                return;
            }
            try
            {

                lbThongbaoKho.Text = "";
                bdsKho.EndEdit();
                bdsKho.ResetCurrentItem();
                if (dS.HasChanges())
                {

                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.dS.Kho);
                }


            }
            catch (Exception exp)
            {

                if (exp.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã kho bị trùng.", "Lỗi Kho", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Lỗi Ghi kho. Bạn kiểm tra lại thông tin kho trứơc khi ghi.", "Lỗi Kho", MessageBoxButtons.OK);
                }
            }
            gcKho.Enabled = true;
            gbCTKho.Enabled = false;
            btnThemKho.Enabled = btnXoaKho.Enabled = btnSuaKho.Enabled = btnRefreshKho.Enabled = btnThoatKho.Enabled = true;
            btnGhiKho.Enabled = btnUndoKho.Enabled = false;
        }

        private void btnUndoKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbThongbaoKho.Text = "";
            bdsKho.CancelEdit();
            if (btnThemKho.Enabled == false) bdsKho.Position = vitri;
            gcKho.Enabled = true;
            gbCTKho.Enabled = false;
            btnThemKho.Enabled = btnXoaKho.Enabled = btnSuaKho.Enabled = btnRefreshKho.Enabled = btnThoatKho.Enabled = true;
            btnGhiKho.Enabled = btnUndoKho.Enabled = false;
        }

        private void btnRefreshKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.dS.Kho);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoatKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Visible = false;
        }

        private void btnXoaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_KIEMTRAMAKHOTRONGPHIEU] N'" + txtMAKHO.Text.Trim() + "' SELECT  'Return Value' = @return_value";
            SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);
            if (myreader == null) return;
            myreader.Read();
            int dem = myreader.GetInt32(0);
            myreader.Close();
            if (dem != 0)
            {
                MessageBox.Show("Kho đã có trong phiếu. Không thể xóa !", "Lỗi xóa phiếu", MessageBoxButtons.OK);
            }
            else
            {
                string makho = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa kho này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    try
                    {
                        bdsKho.RemoveCurrent();
                        this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khoTableAdapter.Update(this.dS.Kho);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa kho. Bạn hãy xóa lại\n" + ex.Message, "",
                            MessageBoxButtons.OK);
                        this.khoTableAdapter.Fill(this.dS.Kho);
                        bdsKho.Position = bdsKho.Find("MAKHO", makho);
                        return;
                    }
                }
            }
        }
    }
}

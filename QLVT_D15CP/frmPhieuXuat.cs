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
    public partial class frmPhieuXuat : Form
    {
        int vitri = 0;
        string macn = "";
        public frmPhieuXuat()
        {
            InitializeComponent();
            gbPX.Enabled = false;
        }
        public void LoadDataToComboBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MANV,HOTEN from V_LAYTENNHANVIEN", Program.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbNhanvien.DataSource = dt;
            cmbNhanvien.ValueMember = "MANV";
            cmbNhanvien.DisplayMember = "HOTEN";
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

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            // TODO: This line of code loads data into the 'dS_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
            this.LoadDataToComboBox();
            this.LoadDataToComboBox2();
            cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;
                btnThemPX.Enabled = false;
                btnSuaPX.Enabled = false;
                btnGhiPX.Enabled = false;
                btnUndoPX.Enabled = false;
                btnXoaPX.Enabled = false;
                btnRefreshPX.Enabled = false;

            } // bật tắt theo phân quyền
            else
            {
                cmbChinhanh.Enabled = false;
                btnThemPX.Enabled = true;
                btnSuaPX.Enabled = true;
                btnGhiPX.Enabled = false;
                btnUndoPX.Enabled = false;
                btnXoaPX.Enabled = true;
                btnRefreshPX.Enabled = true;
            }
        }

        private void btnThoatPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);

                    // macn = ((DataRowView)bdsDathang[0])["MACN"].ToString().Trim();
                }
            }
            catch (NullReferenceException exp) { }
        }

        private void btnThemPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCTPX f = new frmCTPX();
            f.Show();
        }

        private void btnSuaPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsPX.Position;
            gbPX.Enabled = true;
            txtMAPX.Enabled = false;
            btnThemPX.Enabled = btnSuaPX.Enabled = btnXoaPX.Enabled = btnRefreshPX.Enabled = btnThoatPX.Enabled = false;
            btnGhiPX.Enabled = btnUndoPX.Enabled = true;
            gcPX.Enabled = false;
            txtNGAYPX.Focus();
        }

        private void btnUndoPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbThongbao.Text = "";
            bdsPX.CancelEdit();
            if (btnThemPX.Enabled == false) bdsPX.Position = vitri;
            gcPX.Enabled = true;
            gbPX.Enabled = false;
            btnThemPX.Enabled = btnSuaPX.Enabled = btnXoaPX.Enabled = btnRefreshPX.Enabled = btnThoatPX.Enabled = true;
            btnGhiPX.Enabled = btnUndoPX.Enabled = false;
        }

        private void btnRefreshPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnGhiPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                lbThongbao.Text = "";
                bdsPX.EndEdit();
                bdsPX.ResetCurrentItem();
                bdsCTPX.EndEdit();
                bdsCTPX.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPXTableAdapter.Update(this.dS.CTPX);
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.dS.PhieuXuat);
                }


            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi Ghi Phiếu nhập. Bạn kiểm tra lại thông tin phiếu nhập trứơc khi ghi.", "Lỗi Phiếu nhập", MessageBoxButtons.OK);
            }
            gcPX.Enabled = true;
            gbPX.Enabled = false;
            btnThemPX.Enabled = btnSuaPX.Enabled = btnXoaPX.Enabled = btnRefreshPX.Enabled = btnThoatPX.Enabled = true;
            btnGhiPX.Enabled = btnUndoPX.Enabled = false;
        }

        private void cmbNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMANV.Text = cmbNhanvien.SelectedValue.ToString();
        }

        private void cmbMAKHO_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMAKHO.Text = cmbMAKHO.SelectedValue.ToString();
        }

        private void btnXoaPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //for (int i = 0; i < cTPXDataGridView.Rows.Count; i++)
            //{
            //    string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_LAYSLTTHEOMAVT] N'" + cTPXDataGridView.Rows[i].Cells[0].Value.ToString() + "' SELECT  'Return Value' = @return_value";
            //    SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);
            //    if (myreader == null) return;
            //    myreader.Read();
            //    int SLT = myreader.GetInt32(0);
            //    myreader.Close();
            //    int SLT_REMOVE = SLT - int.Parse(cTPNDataGridView.Rows[i].Cells[1].Value.ToString());
            //    if (SLT_REMOVE < 0)
            //    {
            //        MessageBox.Show("Phiếu nhập không thể xóa vì SLT sau khi xóa < 0 !", "Lỗi xóa phiếu", MessageBoxButtons.OK);
            //        return;
            //    }
            //}
            string MasoPX = ((DataRowView)bdsPX[bdsPX.Position])["MAPX"].ToString();
            if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu xuất này ?? ", "Xác nhận",
                   MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    int row = cTPXDataGridView.Rows.Count;
                    for (int i = 0; i < row; i++)
                    {
                        String strLenhCapnhatSLT = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_THEMSLT]  N'" + cTPXDataGridView.Rows[0].Cells[0].Value.ToString() + "'," + int.Parse(cTPXDataGridView.Rows[0].Cells[1].Value.ToString()) + "SELECT  'Return Value' = @return_value";
                        Program.ExecSqlDataReader(strLenhCapnhatSLT);
                        Program.conn.Close();
                        cTPXDataGridView.Rows.RemoveAt(0);
                    }
                    bdsPX.RemoveCurrent();
                    if (dS.HasChanges())
                    {
                        this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cTPXTableAdapter.Update(this.dS.CTPX);
                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuXuatTableAdapter.Update(this.dS.PhieuXuat);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu xuất. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
                    bdsPX.Position = bdsPX.Find("MAPX", MasoPX);
                    return;
                }
            }
        }
    }
}

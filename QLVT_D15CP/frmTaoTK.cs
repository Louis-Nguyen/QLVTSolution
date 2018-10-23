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
    public partial class frmTaoTK : Form
    {
        public frmTaoTK()
        {
            InitializeComponent();
        }
        private void frmTaoTK_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            if (Program.mGroup == "CONGTY")
            {
                cmbRole.Items.Remove("CHINHANH");
                cmbRole.Items.Remove("USER");
            }
            if (Program.mGroup == "CHINHANH")
            {
                cmbRole.Items.Remove("CONGTY");
            }
            cmbRole.SelectedIndex = 0;
            txtHO.Enabled = false;
            txtTEN.Enabled = false;
            txtMANV.Enabled = false;
            txtTTX.Enabled = false;
           
        }
        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVienTaoLogin.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        private void TaoLogin_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMANV.Text.Trim();
            string tenDangNhap = txtLogin.Text;
            string matKhau = txtPass.Text;
            string quyenHan = cmbRole.Text.ToString();
            if (txtTTX.Text.Trim().Equals("1"))
            {
                MessageBox.Show("Nhân viên đã xóa,Không thể tạo tài khoản cho nhân viên này!");
                return;
            }
            if (Program.username.Equals(maNhanVien))
            {
                MessageBox.Show("Bạn không thể tạo đăng nhập cho chính bạn!");
                return;
            }
            if (tenDangNhap.Equals(""))
            {
                MessageBox.Show("Tên đăng nhập không được để trống !");
                txtLogin.Focus();
                return;
            }
            if (matKhau.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống !");
                txtPass.Focus();
                return;
            }

            SqlDataReader myReader;

            String strLenh = "EXEC  SP_TAOLOGIN N'"
                + tenDangNhap + "',N'" + matKhau + "',N'" + maNhanVien + "','" + quyenHan + "'";
            try
            {
                myReader = Program.ExecSqlDataReader(strLenh);

                if (myReader != null)
                {
                    MessageBox.Show("Tạo login thành công!");
                    myReader.Close();
                    Program.conn.Close();
                    frmTaoTK_Load(sender, e);
                    txtLogin.Text = "";
                    txtPass.Text = "";
                    cmbRole.SelectedIndex = 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể tạo login !");
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPass.Text = "";
            cmbRole.SelectedIndex = 0;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

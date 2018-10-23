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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
            cmbChinhanh.SelectedIndex = 1;
            cmbChinhanh.SelectedIndex = 0;
        }
        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChinhanh.SelectedValue != null)
            {
                Program.servername = cmbChinhanh.SelectedValue.ToString();
            }
        }
   
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng!", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;

            SqlDataReader myReader;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            Program.mChinhanh = cmbChinhanh.SelectedIndex;
            Program.bds_dspm = bdsDSPM;

            string strLenh = "EXEC SP_DANGNHAP'" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();

            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username) != false)
            {
                MessageBox.Show("Đăng nhập thất bại \n Bạn vui lòng xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();
            this.SetVisibleCore(false);
            frmMain main = new frmMain();
            main.MANV.Text = "Mã Nhân Viên : " + Program.username;
            main.HOTEN.Text = "Họ Tên : " + Program.mHoten;
            main.NHOM.Text = "Nhóm :  " + Program.mGroup;
            main.Show();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN MUỐN THOÁT CHƯƠNG TRÌNH KHÔNG ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.SetVisibleCore(false);
                Application.Exit();
            }
        }
        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.SetVisibleCore(false);
            Application.Exit();
        }
    }
}

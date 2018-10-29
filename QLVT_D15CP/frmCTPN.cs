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
    public partial class frmCTPN : Form
    {
        public string maDDH = "";
        int thanhtien = 0;
        public frmCTPN()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        public void LoadDataToComboBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MAVT,TENVT from V_LAYTENVT", Program.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbVattu.DataSource = dt;
            cmbVattu.ValueMember = "MAVT";
            cmbVattu.DisplayMember = "TENVT";
        }
        public void LoadDataToComboBox1()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MasoDDH from V_MSDDH", Program.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmaDDH.DataSource = dt;
            cmbmaDDH.ValueMember = "MasoDDH";
            cmbmaDDH.DisplayMember = "MasoDDH";
        }
        public void LoadDataToComboBox2()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MAKHO,TENKHO from V_LAYTENKHO", Program.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMAKHO.DataSource = dt;
            cmbMAKHO.ValueMember = "MAKHO";
            cmbMAKHO.DisplayMember = "TENKHO";
        }
        public void HienThiDanhSachCTDDH(string MsDDH)
        {
            tblChiTietPN.Columns.Clear();
            SqlDataReader myReader;
            String lenh = "EXEC SP_XEMCTDDHTHEOMADDH N'" + MsDDH + "'";
            myReader = Program.ExecSqlDataReader(lenh);
            DataTable dt = new DataTable();
            dt.Load(myReader);
            tblChiTietPN.DataSource = dt;
            this.tblChiTietPN.Columns.Remove("MasoDDH");
            this.tblChiTietPN.Columns.Add("SOLUONGNHAP", "SOLUONGNHAP");
            this.tblChiTietPN.Columns.Add("DONGIANHAP", "DONGIANHAP");
            this.tblChiTietPN.Columns["MAVT"].ReadOnly = true;
            this.tblChiTietPN.Columns["SOLUONGNHAP"].ReadOnly = true;
            this.tblChiTietPN.Columns["DONGIANHAP"].ReadOnly = true;
            this.tblChiTietPN.Columns["SOLUONG"].ReadOnly = true;
            this.tblChiTietPN.Columns["DONGIA"].ReadOnly = true;
            tblChiTietPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
      

        private void xuLyTongTien()
        {
            try
            {
                if (tblChiTietPN.Rows.Count >= 1)
                {
                     thanhtien = 0;
                    for (int i = 0; i <= tblChiTietPN.Rows.Count - 1; i++)
                    {
                        thanhtien += int.Parse(tblChiTietPN.Rows[i].Cells[3].Value.ToString())* int.Parse(tblChiTietPN.Rows[i].Cells[4].Value.ToString());
                    }
                    txtTongTien.Text = thanhtien.ToString();
                }
                else
                {
                    txtTongTien.Text = "0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("123");
            }
        }
        public void HienThi(string maDDH)
        {
            HienThiDanhSachCTDDH(maDDH);
            if (tblChiTietPN.Rows.Count >= 1)
            {

                for (int i = 0; i <= tblChiTietPN.Rows.Count - 1; i++)
                {
                    tblChiTietPN.Rows[i].Cells["SOLUONGNHAP"].Value = int.Parse(tblChiTietPN.Rows[i].Cells[1].Value.ToString());
                    tblChiTietPN.Rows[i].Cells["DONGIANHAP"].Value = int.Parse(tblChiTietPN.Rows[i].Cells[2].Value.ToString());
                }
            }

        }


        private void frmCTPN_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            this.LoadDataToComboBox();
            this.LoadDataToComboBox1();
            this.LoadDataToComboBox2();
            bdsPN.AddNew();
            txtMAPN.Focus();
            txtMANVPN.Text = Program.username;
            txtMANVPN.Enabled = false;
            txtNGAYPN.DateTime = DateTime.Now;
            txtNGAYPN.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int dong = tblChiTietPN.CurrentRow.Index;
            string mavattu = cmbVattu.SelectedValue.ToString();
            float donGiaNhap = float.Parse(txtDG.Text.Trim());
                if (donGiaNhap < 0)
                {
                    MessageBox.Show("Đơn giá nhập phải lớn hơn 0!");
                    tblChiTietPN.Rows[dong].Cells["DONGIANHAP"].Value = int.Parse(tblChiTietPN.Rows[dong].Cells[2].Value.ToString());
                    return;
                }
            int soLuongNhap = int.Parse(txtSL.Text.Trim());
                if (soLuongNhap < 0)
                {
                    MessageBox.Show("Số lượng nhập phải lớn hơn 0!");
                    tblChiTietPN.Rows[dong].Cells["SOLUONGNHAP"].Value = int.Parse(tblChiTietPN.Rows[dong].Cells[1].Value.ToString());
                    return;
                }
                if(soLuongNhap > int.Parse(tblChiTietPN.Rows[dong].Cells[1].Value.ToString()))
                {
                    MessageBox.Show("Số lượng nhập phải nhỏ hơn số lượng trong đơn đặt hàng!");
                    tblChiTietPN.Rows[dong].Cells["SOLUONGNHAP"].Value = int.Parse(tblChiTietPN.Rows[dong].Cells[1].Value.ToString());
                    return;
                 }
            if (tblChiTietPN.Rows.Count >= 1)
            {

                tblChiTietPN.CurrentCell = tblChiTietPN.Rows[dong].Cells[0];
                if (mavattu.Equals(tblChiTietPN.CurrentCell.Value.ToString()))
                {
                    //tblChiTietPN.CurrentCell = tblChiTietPN.Rows[dong].Cells[3];
                    tblChiTietPN.Rows[dong].Cells[3].Value = soLuongNhap;
                    //tblChiTietPN.CurrentCell = tblChiTietPN.Rows[dong].Cells[4];
                    tblChiTietPN.Rows[dong].Cells[4].Value = donGiaNhap;
                    xuLyTongTien();
                    
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu chi tiết phiếu nhập!","Lỗi cập nhật", MessageBoxButtons.OK);
                    return;
                }
               
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = tblChiTietPN.CurrentRow.Index;
                if (tblChiTietPN.Rows.Count > 1)
                {
                    for (int i = dong; i < tblChiTietPN.Rows.Count - 1; i++)
                    {
                        tblChiTietPN.Rows[i].Cells[0].Value = tblChiTietPN.Rows[i + 1].Cells[0].Value;
                        tblChiTietPN.Rows[i].Cells[1].Value = tblChiTietPN.Rows[i + 1].Cells[1].Value;
                        tblChiTietPN.Rows[i].Cells[2].Value = tblChiTietPN.Rows[i + 1].Cells[2].Value;
                        tblChiTietPN.Rows[i].Cells[3].Value = tblChiTietPN.Rows[i + 1].Cells[3].Value;
                        tblChiTietPN.Rows[i].Cells[4].Value = tblChiTietPN.Rows[i + 1].Cells[4].Value;
                    }
                    tblChiTietPN.Rows.RemoveAt(tblChiTietPN.Rows.Count - 1);
                    xuLyTongTien();
                }

                else
                {

                    MessageBox.Show("Trong bảng chi tiết phiếu nhập phải tồn tại ít nhất một vật tư!","Lỗi xóa chi tiết vật tư",MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmbmaDDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            maDDH = cmbmaDDH.SelectedValue.ToString().Trim();
            HienThi(maDDH);
            xuLyTongTien();
        }

       

        private void tblChiTietPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = tblChiTietPN.CurrentRow.Index;
            cmbVattu.SelectedValue = tblChiTietPN.Rows[dong].Cells[0].Value.ToString();
            txtSL.Text = tblChiTietPN.Rows[dong].Cells[1].Value.ToString();
            txtDG.Text = tblChiTietPN.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnLapPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ma = txtMAPN.Text;
            SqlDataReader myReader;
            SqlDataReader myReader1;
            SqlDataReader myReaderKT;
            string maNhanVien = Program.username;
            string masoDDH = cmbmaDDH.SelectedValue.ToString();
            string maKho = cmbMAKHO.SelectedValue.ToString();
            if (ma.Trim().Equals(""))
            {
                MessageBox.Show("Mã phiếu nhập không được trống !");
                txtMAPN.Focus();
                return;
            }
            String strLenhKT = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KIEMTRAPN_TONTAI] @MAPN = N'" + ma.Trim() + "' SELECT  'Return Value' = @return_value";
            myReaderKT = Program.ExecSqlDataReader(strLenhKT);
            myReaderKT.Read();
            int dem = myReaderKT.GetInt32(0);
            myReaderKT.Close();
            if (dem == 1)
            {
                MessageBox.Show("Mã phiếu nhập bị trùng.", "Lỗi thêm Phiếu nhập", MessageBoxButtons.OK);
                txtMAPN.Focus();
                return;
            }
            if (tblChiTietPN.Rows.Count == 0)
            {
                MessageBox.Show("Thông tin vật tư đặt hàng không được để trống! ");
                return;
            }
            String strLenh = "EXEC  SP_INSERTPHIEUNHAP N'"
                   + ma + "', N'" + DateTime.Now.ToString() + "', N'" + masoDDH + "', " + maNhanVien + ", N'" + maKho + "'";
            try
            {
                myReader = Program.ExecSqlDataReader(strLenh);

                if (myReader != null)
                {
                    myReader.Close();
                    if (tblChiTietPN.Rows.Count >= 1)
                    {


                        for (int i = 0; i < tblChiTietPN.Rows.Count ; i++)
                        {
                            String strLenh1 = "EXEC  SP_INSERTCTPN N'"
                            + ma + "', N'" + tblChiTietPN.Rows[i].Cells[0].Value.ToString() + "'," + int.Parse(tblChiTietPN.Rows[i].Cells[3].Value.ToString()) + "," + int.Parse(tblChiTietPN.Rows[i].Cells[4].Value.ToString())  ;
                            myReader1 = Program.ExecSqlDataReader(strLenh1);
                           
                            if (myReader1 != null)
                            {
                                myReader1.Close();
                                Program.conn.Close();
                            }
                            String strLenhCapnhatSLT = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_THEMSLT]  N'" + tblChiTietPN.Rows[i].Cells[0].Value.ToString() + "'," + int.Parse(tblChiTietPN.Rows[i].Cells[3].Value.ToString()) + "SELECT  'Return Value' = @return_value";
                            Program.ExecSqlDataReader(strLenhCapnhatSLT);
                            Program.conn.Close();
                        }
                    }
                    Program.conn.Close();
                }
                MessageBox.Show("Lập phiếu đặt hàng thành công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể lập phiếu đặt hàng ! ");
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}

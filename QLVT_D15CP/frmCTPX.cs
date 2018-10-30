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
    public partial class frmCTPX : Form
    {
        int thanhtien = 0;
        public frmCTPX()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPX.EndEdit();
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
        public void LoadDataToComboBox2()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MAKHO,TENKHO from V_LAYTENKHO", Program.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKHO.DataSource = dt;
            cmbKHO.ValueMember = "MAKHO";
            cmbKHO.DisplayMember = "TENKHO";
        }
        private bool kiemTraTenVatTu(string name)
        {
            for (int i = 0; i < cTPXDataGridView.Rows.Count - 1; i++)
            {
                if (name.Equals(cTPXDataGridView.Rows[i].Cells[1].Value.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        private void xuLyTongTien()
        {
            try
            {
                if (cTPXDataGridView.Rows.Count > 1)
                {
                    int thanhtien = 0;
                    for (int i = 0; i < cTPXDataGridView.Rows.Count - 1; i++)
                    {
                        thanhtien += int.Parse(cTPXDataGridView.Rows[i].Cells[4].Value.ToString());
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
                MessageBox.Show("Lỗi tính tổng tiền");
            }
        }
        private void frmCTPX_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            this.LoadDataToComboBox();
            this.LoadDataToComboBox2();
            bdsPX.AddNew();
            txtMAPX.Focus();
            txtMANVPX.Text = Program.username;
            txtNGAYPX.DateTime = DateTime.Now;
        }

        private void btnThoatPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            int thanhTien = 0;
            string tenVatTu = "";
            string soLuong = "";
            string donGia = "";
            string mavattu = "";
            mavattu = cmbVattu.SelectedValue.ToString();
            tenVatTu = cmbVattu.Text.ToString();
            soLuong = txtSL.Text.Trim();
            donGia = txtDG.Text.Trim();
            thanhTien = int.Parse(soLuong) * int.Parse(donGia);
            if (int.Parse(soLuong) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                return;
            }
            if (int.Parse(donGia) <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0");
                return;
            }
            if (cTPXDataGridView.Rows.Count > 1)
            {
                if (kiemTraTenVatTu(tenVatTu))
                {
                    MessageBox.Show("Tên vật tư đã bị trùng. Bạn có thể cập nhật và xóa");
                    return;
                }

            }
            cTPXDataGridView.Rows.Add(mavattu, tenVatTu, soLuong, donGia, thanhTien.ToString());
            xuLyTongTien();
        }

        private void btnUpdateCT_Click(object sender, EventArgs e)
        {
            int thanhTien = 0;
            string tenVatTu = "";
            string soLuong = "";
            string donGia = "";
            string mavattu = cmbVattu.SelectedValue.ToString();
            tenVatTu = cmbVattu.Text;
            soLuong = txtSL.Text.Trim();
            donGia = txtDG.Text.Trim();
            thanhTien = int.Parse(soLuong) * int.Parse(donGia);
            int dong = cTPXDataGridView.CurrentRow.Index;

            if (cTPXDataGridView.Rows.Count > 1)
            {

                cTPXDataGridView.CurrentCell = cTPXDataGridView.Rows[dong].Cells[1];
                if (tenVatTu.Equals(cTPXDataGridView.CurrentCell.Value.ToString()))
                {
                    cTPXDataGridView.CurrentCell = cTPXDataGridView.Rows[dong].Cells[2];
                    cTPXDataGridView.CurrentCell.Value = soLuong;
                    cTPXDataGridView.CurrentCell = cTPXDataGridView.Rows[dong].Cells[3];
                    cTPXDataGridView.CurrentCell.Value = donGia;
                    cTPXDataGridView.CurrentCell = cTPXDataGridView.Rows[dong].Cells[4];
                    cTPXDataGridView.CurrentCell.Value = thanhTien;
                    return;
                }
                if (kiemTraTenVatTu(tenVatTu))
                {
                    MessageBox.Show("Tên vật tư đã bị trùng bạn không thể cập nhật ");
                    return;
                }
                cTPXDataGridView.CurrentCell.Value = tenVatTu;
                cTPXDataGridView.CurrentCell = cTPXDataGridView.Rows[dong].Cells[0];
                cTPXDataGridView.CurrentCell.Value = mavattu;
            }



            xuLyTongTien();
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = cTPXDataGridView.CurrentRow.Index;
                if (cTPXDataGridView.Rows.Count > 1)
                {
                    for (int i = dong; i < cTPXDataGridView.Rows.Count - 1; i++)
                    {
                        cTPXDataGridView.Rows[i].Cells[0].Value = cTPXDataGridView.Rows[i + 1].Cells[0].Value;
                        cTPXDataGridView.Rows[i].Cells[1].Value = cTPXDataGridView.Rows[i + 1].Cells[1].Value;
                        cTPXDataGridView.Rows[i].Cells[2].Value = cTPXDataGridView.Rows[i + 1].Cells[2].Value;
                        cTPXDataGridView.Rows[i].Cells[3].Value = cTPXDataGridView.Rows[i + 1].Cells[3].Value;
                        cTPXDataGridView.Rows[i].Cells[4].Value = cTPXDataGridView.Rows[i + 1].Cells[4].Value;
                    }
                    cTPXDataGridView.RowCount--;
                    xuLyTongTien();
                }

                else
                {

                    MessageBox.Show("Bảng đã không còn giá trị để xóa");
                }
            }
            catch (Exception)
            {

            }
        }

        private void cTPXDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = cTPXDataGridView.CurrentRow.Index;
            cmbVattu.Text = cTPXDataGridView.Rows[dong].Cells[1].Value.ToString();
            txtSL.Text = cTPXDataGridView.Rows[dong].Cells[2].Value.ToString();
            txtDG.Text = cTPXDataGridView.Rows[dong].Cells[3].Value.ToString();
        }

        private void cmbVattu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSL.Text = "";
            txtDG.Text = "";
        }

        private void btnLapPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ma = txtMAPX.Text;
            SqlDataReader myReader;
            SqlDataReader myReader1;
            SqlDataReader myReaderKT;
            string maNhanVien = Program.username;
            string maKho = cmbKHO.SelectedValue.ToString();
            if (ma.Trim().Equals(""))
            {
                MessageBox.Show("Mã phiếu xuất không được trống !");
                txtMAPX.Focus();
                return;
            }
            String strLenhKT = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KIEMTRAPX_TONTAI] N'" + ma.Trim() + "' SELECT  'Return Value' = @return_value";
            myReaderKT = Program.ExecSqlDataReader(strLenhKT);
            myReaderKT.Read();
            int dem = myReaderKT.GetInt32(0);
            myReaderKT.Close();
            if (dem == 1)
            {
                MessageBox.Show("Mã phiếu xuất bị trùng.", "Lỗi thêm Phiếu xuất", MessageBoxButtons.OK);
                txtMAPX.Focus();
                return;
            }
            if (txtHOTENKH.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông tin khách hàng không được để trống! ");
                txtHOTENKH.Focus();
                return;
            }
            if (cTPXDataGridView.Rows.Count <= 1 )
            {
                MessageBox.Show("Thông tin vật tư đặt hàng không được để trống! ");
                return;
            }
            String strLenh = "EXEC  SP_INSERTPHIEUXUAT N'"
                   + ma + "', N'" + DateTime.Now.ToString() + "', N'" +  txtHOTENKH.Text.Trim() + "', " + maNhanVien + ", N'" + maKho + "'";
            try
            {
                myReader = Program.ExecSqlDataReader(strLenh);

                if (myReader != null)
                {
                    myReader.Close();
                    if (cTPXDataGridView.Rows.Count >= 1)
                    {


                        for (int i = 0; i < cTPXDataGridView.Rows.Count - 1 ; i++)
                        {
                            String strLenh1 = "EXEC  SP_INSERTCTPX N'"
                            + ma + "', N'" + cTPXDataGridView.Rows[i].Cells[0].Value.ToString() + "'," + int.Parse(cTPXDataGridView.Rows[i].Cells[2].Value.ToString()) + "," + float.Parse(cTPXDataGridView.Rows[i].Cells[3].Value.ToString());
                            myReader1 = Program.ExecSqlDataReader(strLenh1);

                            if (myReader1 != null)
                            {
                                myReader1.Close();
                                Program.conn.Close();
                            }
                            String strLenhCapnhatSLT = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_GIAMSLT]  N'" + cTPXDataGridView.Rows[i].Cells[0].Value.ToString() + "'," + int.Parse(cTPXDataGridView.Rows[i].Cells[2].Value.ToString()) + "SELECT  'Return Value' = @return_value";
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

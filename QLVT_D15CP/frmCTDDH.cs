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
    public partial class frmCTDDH : Form
    {
        public frmCTDDH()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDDH.EndEdit();
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
        private bool kiemTraTenVatTu(string name)
        {
            for (int i = 0; i < tblChiTietDDH.Rows.Count - 1; i++)
            {
                if (name.Equals(tblChiTietDDH.Rows[i].Cells[1].Value.ToString()))
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
                if (tblChiTietDDH.Rows.Count > 1)
                {
                    int thanhtien = 0;
                    for (int i = 0; i < tblChiTietDDH.Rows.Count - 1; i++)
                    {
                        thanhtien += int.Parse(tblChiTietDDH.Rows[i].Cells[4].Value.ToString());
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
       
        public void LoadDataToComboBox2()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MAKHO,TENKHO from V_LAYTENKHO", Program.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMAKHO.DataSource = dt;
            cmbMAKHO.ValueMember = "MAKHO";
            cmbMAKHO.DisplayMember = "TENKHO";
        }
        private void frmCTDDH_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.dS.DatHang);
            this.LoadDataToComboBox();
            this.LoadDataToComboBox2();
            bdsDDH.AddNew();
            txtMSDDHCT.Focus();
        }

        private void cmbMAKHO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoatCTDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = tblChiTietDDH.CurrentRow.Index;
                if (tblChiTietDDH.Rows.Count > 1)
                {
                    for (int i = dong; i < tblChiTietDDH.Rows.Count - 1; i++)
                    {
                        tblChiTietDDH.Rows[i].Cells[0].Value = tblChiTietDDH.Rows[i + 1].Cells[0].Value;
                        tblChiTietDDH.Rows[i].Cells[1].Value = tblChiTietDDH.Rows[i + 1].Cells[1].Value;
                        tblChiTietDDH.Rows[i].Cells[2].Value = tblChiTietDDH.Rows[i + 1].Cells[2].Value;
                        tblChiTietDDH.Rows[i].Cells[3].Value = tblChiTietDDH.Rows[i + 1].Cells[3].Value;
                        tblChiTietDDH.Rows[i].Cells[4].Value = tblChiTietDDH.Rows[i + 1].Cells[4].Value;
                    }
                    tblChiTietDDH.RowCount--;
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
            if (tblChiTietDDH.Rows.Count > 1)
            {
                if (kiemTraTenVatTu(tenVatTu))
                {
                    MessageBox.Show("Tên vật tư đã bị trùng. Bạn có thể cập nhật và xóa");
                    return;
                }

            }
            tblChiTietDDH.Rows.Add(mavattu, tenVatTu, soLuong, donGia, thanhTien.ToString());
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
            int dong = tblChiTietDDH.CurrentRow.Index;

            if (tblChiTietDDH.Rows.Count > 1)
            {

                tblChiTietDDH.CurrentCell = tblChiTietDDH.Rows[dong].Cells[1];
                if (tenVatTu.Equals(tblChiTietDDH.CurrentCell.Value.ToString()))
                {
                    tblChiTietDDH.CurrentCell = tblChiTietDDH.Rows[dong].Cells[2];
                    tblChiTietDDH.CurrentCell.Value = soLuong;
                    tblChiTietDDH.CurrentCell = tblChiTietDDH.Rows[dong].Cells[3];
                    tblChiTietDDH.CurrentCell.Value = donGia;
                    tblChiTietDDH.CurrentCell = tblChiTietDDH.Rows[dong].Cells[4];
                    tblChiTietDDH.CurrentCell.Value = thanhTien;
                    return;
                }
                if (kiemTraTenVatTu(tenVatTu))
                {
                    MessageBox.Show("Tên vật tư đã bị trùng bạn không thể cập nhật ");
                    return;
                }
                tblChiTietDDH.CurrentCell.Value = tenVatTu;
                tblChiTietDDH.CurrentCell = tblChiTietDDH.Rows[dong].Cells[0];
                tblChiTietDDH.CurrentCell.Value = mavattu;
            }



            xuLyTongTien();
        }

        private void tblChiTietDDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = tblChiTietDDH.CurrentRow.Index;
            cmbVattu.Text = tblChiTietDDH.Rows[dong].Cells[1].Value.ToString();
            txtSL.Text = tblChiTietDDH.Rows[dong].Cells[2].Value.ToString();
            txtDG.Text = tblChiTietDDH.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnLapDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ma = txtMSDDHCT.Text;
            SqlDataReader myReader;
            SqlDataReader myReader1;
            string maNhanVien = Program.username;
            string nhaCungCap = txtNHACCCT.Text;
            string maKho = cmbMAKHO.SelectedValue.ToString();
            if (nhaCungCap.Trim().Equals(""))
            {
                MessageBox.Show("Tên nhà cung cấp không được trống !");
                txtNHACCCT.Focus();
                return;
            }
            if (tblChiTietDDH.Rows.Count == 1)
            {
                MessageBox.Show("Thông tin vật tư đặt hàng không được để trống! ");
                return;
            }
            String strLenh = "EXEC  SP_INSERTDATHANG N'"
                   + ma + "', N'" + DateTime.Now.ToString() + "', N'" + nhaCungCap + "', " + maNhanVien + ", N'" + maKho + "'";
            try
            {
                myReader = Program.ExecSqlDataReader(strLenh);

                if (myReader != null)
                {
                    myReader.Close();
                    if (tblChiTietDDH.Rows.Count > 1)
                    {


                        for (int i = 0; i < tblChiTietDDH.Rows.Count - 1; i++)
                        {
                            String strLenh1 = "EXEC  SP_INSERTCTDDH'"
                            + ma + "','" + tblChiTietDDH.Rows[i].Cells[0].Value.ToString() + "','" + tblChiTietDDH.Rows[i].Cells[2].Value.ToString() + "','" + tblChiTietDDH.Rows[i].Cells[3].Value.ToString() + "'";
                            myReader1 = Program.ExecSqlDataReader(strLenh1);
                            if (myReader1 != null)
                            {
                                myReader1.Close();
                                Program.conn.Close();
                            }
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

        private void cmbVattu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSL.Text = "";
            txtDG.Text = "";
        }
    }
}

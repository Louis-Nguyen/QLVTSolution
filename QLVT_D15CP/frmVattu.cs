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
    public partial class frmVattu : Form
    {
        int vitri = 0;
        public frmVattu()
        {
            InitializeComponent();
            gbCTVT.Enabled = false;
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVattu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmVattu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            if (Program.mGroup == "CONGTY")
            {
                btnThemVT.Enabled = false;
                btnSuaVT.Enabled = false;
                btnGhiVT.Enabled = false;
                btnXoaVT.Enabled = false;
                btnUndoVT.Enabled = false;
                btnRefreshVT.Enabled = false;

            } // bật tắt theo phân quyền
            else
            {
                btnThemVT.Enabled = true;
                btnSuaVT.Enabled = true;
                btnGhiVT.Enabled = false;
                btnXoaVT.Enabled = true;
                btnUndoVT.Enabled = false;
                btnRefreshVT.Enabled = true;

            }
        }

        private void btnThemVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVattu.Position;
            gbCTVT.Enabled = true;
            gcVattu.Enabled = false;
            bdsVattu.AddNew();
            txtSLT.Text = "0";
            txtSLT.Enabled = false;
            btnThemVT.Enabled = btnSuaVT.Enabled = btnRefreshVT.Enabled = btnThoatVT.Enabled = false;
            btnGhiVT.Enabled = btnUndoVT.Enabled = true;

            txtMAVT.Focus();
        }

        private void btnSuaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVattu.Position;
            gbCTVT.Enabled = true;
            btnThemVT.Enabled = btnSuaVT.Enabled = btnRefreshVT.Enabled = btnXoaVT.Enabled = btnThoatVT.Enabled = false;
            btnGhiVT.Enabled = btnUndoVT.Enabled = true;
            gcVattu.Enabled = false;
            txtMAVT.Focus();
        }

        private void btnGhiVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAVT.Text.Trim().Equals(""))
            {
                lbThongbaoVT.Text = "Mã vật tư không thể để trống.";
                txtMAVT.Focus();
                return;

            }
            if (txtTENVT.Text.Trim().Equals(""))
            {
                lbThongbaoVT.Text = "Tên vât tư không thể để trống.";
                txtTENVT.Focus();
                return;
            }
            if (txtDVT.Text.Trim().Equals(""))
            {
                lbThongbaoVT.Text = "Đơn vị tính không thể để trống.";
                txtDVT.Focus();
                return;
            }
            try
            {
                lbThongbaoVT.Text = "";
                bdsVattu.EndEdit();
                bdsVattu.ResetCurrentItem();
                if (dS.HasChanges())
                {

                    this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vattuTableAdapter.Update(this.dS.Vattu);
                }
            }
            catch (Exception exp)
            {

                if (exp.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã vật tư bị trùng.", "Lỗi Vật tư", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Lỗi Ghi vật tư. Bạn kiểm tra lại thông tin vật tư trứơc khi ghi.", "Lỗi Vật tư", MessageBoxButtons.OK);
                }
            }
            gcVattu.Enabled = true;
            btnThemVT.Enabled = btnSuaVT.Enabled = btnXoaVT.Enabled = btnRefreshVT.Enabled = btnThoatVT.Enabled = true;
            btnGhiVT.Enabled = btnUndoVT.Enabled = false;
            gbCTVT.Enabled = false;
        }

        private void btnXoaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_KIEMTRAMAVTTRONGPHIEU] N'" + txtMAVT.Text.Trim() + "' SELECT  'Return Value' = @return_value";
            SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);
            if (myreader == null) return;
            myreader.Read();
            int dem = myreader.GetInt32(0);
            myreader.Close();
            if (dem != 0)
            {
                MessageBox.Show("Vật tư đã có trong phiếu. Không thể xóa !", "Lỗi xóa vật tư", MessageBoxButtons.OK);
            }
            else
            {
                string mavt = ((DataRowView)bdsVattu[bdsVattu.Position])["MAVT"].ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    try
                    {
                        bdsVattu.RemoveCurrent();
                        this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.vattuTableAdapter.Update(this.dS.Vattu);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa vật tư. Bạn hãy xóa lại\n" + ex.Message, "",
                            MessageBoxButtons.OK);
                        this.vattuTableAdapter.Fill(this.dS.Vattu);
                        bdsVattu.Position = bdsVattu.Find("MAVT", mavt);
                        return;
                    }
                }
            }
        }

        private void btnUndoVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbThongbaoVT.Text = "";
            bdsVattu.CancelEdit();
            if (btnThemVT.Enabled == false) bdsVattu.Position = vitri;
            gcVattu.Enabled = true;
            gbCTVT.Enabled = false;
            btnThemVT.Enabled = btnSuaVT.Enabled = btnRefreshVT.Enabled = btnXoaVT.Enabled = btnThoatVT.Enabled = true;
            btnGhiVT.Enabled = btnUndoVT.Enabled = false;
        }

        private void btnRefreshVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vattuTableAdapter.Fill(this.dS.Vattu);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoatVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Visible = false;
        }
    }
}

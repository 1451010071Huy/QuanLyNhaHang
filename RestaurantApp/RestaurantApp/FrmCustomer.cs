using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using DTO;
using System.Data.SqlClient;
namespace RestaurantApp
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        private List<DTO_Customer> GetCustomer()
        {
            return new BUS_Customer().GetCustomer();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDanhSáchKháchHàng.DataSource = GetCustomer();
            }
            catch 
            {
               
            }
        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
            int pDiemTichLuy;
            string pHoKH, pTenKH, pSoDienThoaiKH, pNoiSinhKH, pGioiTinhKH, pSoCMNDKH, pDiaChiThuongTru, pEmail;
            DateTime pNgaySinh;

            pHoKH = txtHọKH.Text.Trim();
            pTenKH = txtTênKH.Text.Trim();
            pSoDienThoaiKH = txtSoDienThoai.Text.Trim();
            pNgaySinh = Convert.ToDateTime(dtpNgaySinhKH.Text.ToString());
            pNoiSinhKH = txtNoiSinh.Text.Trim();
            pGioiTinhKH = txtGioiTinh.Text.Trim();
            pSoCMNDKH = txtSoCMND.Text.Trim();
            pDiemTichLuy = Convert.ToInt32(txtDiemTichLuy.Text);
            pDiaChiThuongTru = txtDiaChiThuongTru.Text.Trim();
            pEmail = txtEmail.Text.Trim();

            DTO_Customer emp = new DTO_Customer (pHoKH, pTenKH, pSoDienThoaiKH, pNgaySinh, pNoiSinhKH, pGioiTinhKH, pSoCMNDKH, pDiemTichLuy, pDiaChiThuongTru, pEmail);
            try 
	        {	        
		        int i =  new BUS_Customer().AddCustomer(emp);
                if(i == -2)
                    throw new Exception();

	        }
	        catch (SqlException ex)
	        {
		        MessageBox.Show(ex.Message);
	        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvDanhSáchKháchHàng.DataSource = GetCustomer();

        }

        private void btnXoá_Click(object sender, EventArgs e)
        {
            BUS_Customer dl = new BUS_Customer();
            DTO_Customer dt = new DTO_Customer(Convert.ToInt32(txtMãKH.Text));
            dl.DeleteCustomer(dt);
            dgvDanhSáchKháchHàng.DataSource = GetCustomer();

        }

        private void btnSửa_Click(object sender, EventArgs e)
        {
            int pMaKH, pDiemTichLuy;
            string pHoKH, pTenKH, pSoDienThoaiKH, pNoiSinhKH, pGioiTinhKH, pSoCMNDKH, pDiaChiThuongTru, pEmail;
            DateTime pNgaySinh;

            pMaKH = int.Parse(txtMãKH.Text.Trim());
            pHoKH = txtHọKH.Text.Trim();
            pTenKH = txtTênKH.Text.Trim();
            pSoDienThoaiKH = txtSoDienThoai.Text.Trim();
            pNgaySinh = Convert.ToDateTime(dtpNgaySinhKH.Text.ToString());
            pNoiSinhKH = txtNoiSinh.Text.Trim();
            pGioiTinhKH = txtGioiTinh.Text.Trim();
            pSoCMNDKH = txtSoCMND.Text.Trim();
            pDiemTichLuy = Convert.ToInt32(txtDiemTichLuy.Text);
            pDiaChiThuongTru = txtDiaChiThuongTru.Text.Trim();
            pEmail = txtEmail.Text.Trim();

            DTO_Customer emp = new DTO_Customer (pMaKH, pHoKH, pTenKH, pSoDienThoaiKH, pNgaySinh, pNoiSinhKH, pGioiTinhKH, pSoCMNDKH, pDiemTichLuy, pDiaChiThuongTru, pEmail);
            try 
	        {	        
		        int i =  new BUS_Customer().UpdateCustomer(emp);
                if(i == -2)
                    throw new Exception();

	        }
	        catch (SqlException ex)
	        {
		        MessageBox.Show(ex.Message);
	        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvDanhSáchKháchHàng.DataSource = GetCustomer();
        }

        private void FrmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khônng ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvDanhSáchKháchHàng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

    }
}

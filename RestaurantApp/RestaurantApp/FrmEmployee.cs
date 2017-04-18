using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BUS;
using System.Data.SqlClient;

namespace RestaurantApp
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        int typeSearch = 0;

        //BUS_Employee BUS_emp = new BUS_Employee();
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDanhSachNhanVien.DataSource = GetEmployee();

            }
            catch
            {
                //MessageBox.Show("Khong xuat duoc");
            }
            grbTìmKiếm.Visible = false;
        }


        private List<DTO_Employee> GetEmployee()
        {
            return new BUS_Employee().GetEmployee();
        }
        //Nút tìm kiếm ẩn hiện bảng tìm kiếm 
        private void btnHiểnThịTìmKiếm_Click(object sender, EventArgs e)
        {
            if (grbTìmKiếm.Visible)
                grbTìmKiếm.Hide();
            else
                grbTìmKiếm.Show();
        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
            double pLuongThang;
            string pHoNV, pTenNV, pSodienthoai,  pChucVu,  pGioiTinh, pSoCMND, pDiaChiThuongTru, pEmail;
            DateTime pNgaySinh, pNgayVaoLam;

            pLuongThang = Double.Parse(txtLươngTháng.Text.Trim());
            pHoNV = txtHọNV.Text.Trim();
            pTenNV = txtTênNV.Text.Trim();
            pSodienthoai = txtSoDienThoai.Text.Trim();
            pChucVu = txtChứcVụ.Text.Trim();
            pGioiTinh = txtGiớiTính.Text.Trim();
            pSoCMND = txtSốCMND.Text.Trim();
            pDiaChiThuongTru = txtDiaChiThuongTru.Text.Trim();
            pEmail = txtEmail.Text.Trim();
            pNgaySinh = Convert.ToDateTime(dtpNgaySinh.Text.ToString());
            pNgayVaoLam = Convert.ToDateTime(dtpNgayVaoLam.Text.ToString());

            DTO_Employee emp = new DTO_Employee(pHoNV, pTenNV, pSodienthoai, pNgaySinh, pNgayVaoLam, pChucVu, pLuongThang, pGioiTinh, pSoCMND, pDiaChiThuongTru, pEmail);
            try 
	        {	        
		        int i = new BUS_Employee().Add(emp);
                if (i == -2)
                    throw new Exception();
	        }
	        catch (SqlException ex)
	        {
		        MessageBox.Show(ex.Message);
	        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            dgvDanhSachNhanVien.DataSource = GetEmployee();
           
        }

        private void btnXoá_Click(object sender, EventArgs e)
        {
            BUS_Employee dl = new BUS_Employee();
            DTO_Employee dt = new DTO_Employee(Convert.ToInt32(txtMSNV.Text));
            dl.Delete(dt);
            dgvDanhSachNhanVien.DataSource = GetEmployee();

        }

        private void btnSửa_Click(object sender, EventArgs e)
        {
            int pMaNV;
            double pLuongThang;
            string pHoNV, pTenNV, pSodienthoai, pChucVu, pGioiTinh, pSoCMND, pDiaChiThuongTru, pEmail;
            DateTime pNgaySinh, pNgayVaoLam;

            pMaNV = int.Parse(txtMSNV.Text.Trim());
            pLuongThang = Double.Parse(txtLươngTháng.Text.ToString());
            pHoNV = txtHọNV.Text.Trim();
            pTenNV = txtTênNV.Text.Trim();
            pSodienthoai = txtSoDienThoai.Text.Trim();
            pChucVu = txtChứcVụ.Text.Trim();
            pGioiTinh = txtGiớiTính.Text.Trim();
            pSoCMND = txtSốCMND.Text.Trim();
            pDiaChiThuongTru = txtDiaChiThuongTru.Text.Trim();
            pEmail = txtEmail.Text.Trim();
            pNgaySinh = Convert.ToDateTime(dtpNgaySinh.Text.ToString());
            pNgayVaoLam = Convert.ToDateTime(dtpNgayVaoLam.Text.ToString());

            DTO_Employee emp = new DTO_Employee(pMaNV,pHoNV, pTenNV, pSodienthoai, pNgaySinh, pNgayVaoLam, pChucVu, pLuongThang, pGioiTinh, pSoCMND, pDiaChiThuongTru, pEmail);
            try
            {
                int i = new BUS_Employee().Update(emp);
                if (i == -2)
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


            dgvDanhSachNhanVien.DataSource = GetEmployee();
           
        }
        int typeCheck = 0;
        private void btnTìmKiếm_Click(object sender, EventArgs e)
        {
            switch(typeCheck)
            {
                case 1:
                    {
                                DTO_Employee emp = new DTO_Employee(Convert.ToInt32(txtTìmKiếm.Text));
                                DataTable dt = new DataTable();
                                BUS_Employee em = new BUS_Employee();
                                dt = em.SearchByMaNV(emp);
                                dgvKetQuaTimKiem.DataSource = dt;
                        break;
                    }
                case 2:
                    {
                            DTO_Employee emp = new DTO_Employee();
                            emp.ChucVu = txtTìmKiếm.Text;
                            DataTable dt = new DataTable();
                            BUS_Employee em = new BUS_Employee();
                            dt = em.SearchByChucVu(emp);
                            dgvKetQuaTimKiem.DataSource = dt;
                        break;
                    }
                case 3:
                    {
                        DTO_Employee emp = new DTO_Employee();
                        emp.HoNV = txtTìmKiếm.Text;
                        DataTable dt = new DataTable();
                        BUS_Employee em = new BUS_Employee();
                        dt = em.SearchByHoNhanVien(emp);
                        dgvKetQuaTimKiem.DataSource = dt;
                        break;
                    }
                default:
                    {
                        DTO_Employee emp = new DTO_Employee();
                        emp.TenNV = txtTìmKiếm.Text;
                        DataTable dt = new DataTable();
                        BUS_Employee em = new BUS_Employee();
                        dt = em.SearchByTenNhanVien(emp);
                        dgvKetQuaTimKiem.DataSource = dt;
                        break;
                    }

            }
            
        }

        
        private void dgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int index = e.RowIndex;
            //    //  index = dgvDanhSachNhanVien.CurrentRow.Index;
            //    txtMSNV.Text = dgvDanhSachNhanVien.Rows[index].Cells[0].Value.ToString();
            //    FrmEmployee dgv = new FrmEmployee();
            //    txtHọNV.Text = dgvDanhSachNhanVien.Rows[index].Cells[1].Value.ToString();
            //    txtTênNV.Text = dgvDanhSachNhanVien.Rows[index].Cells[2].Value.ToString();
            //    txtGiớiTính.Text = dgvDanhSachNhanVien.Rows[index].Cells[3].Value.ToString();
            //    dtpNgaySinh.Text = dgvDanhSachNhanVien.Rows[index].Cells[4].Value.ToString();
            //    txtSốCMND.Text = dgvDanhSachNhanVien.Rows[index].Cells[5].Value.ToString();
            //    txtChứcVụ.Text = dgvDanhSachNhanVien.Rows[index].Cells[6].Value.ToString();
            //    dtpNgayVaoLam.Text = dgvDanhSachNhanVien.Rows[index].Cells[7].Value.ToString();
            //    txtLươngTháng.Text = dgvDanhSachNhanVien.Rows[index].Cells[8].Value.ToString();
            //    txtSoDienThoai.Text = dgvDanhSachNhanVien.Rows[index].Cells[9].Value.ToString();
            //    txtDiaChiThuongTru.Text = dgvDanhSachNhanVien.Rows[index].Cells[10].Value.ToString();
            //    txtEmail.Text = dgvDanhSachNhanVien.Rows[index].Cells[11].Value.ToString();
            //}
            //catch { }
        }
        
        private void rdoChứcVụ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChứcVụ.Checked)
            {
                typeCheck = 2;
            }
        }

        private void rdoMãNV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMãNV.Checked)
            {
                typeCheck = 1;
            }
        }

        private void rdoHọNV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHọNV.Checked)
            {
                typeCheck = 3; 
            }
        }

        private void rdoTênNV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTênNV.Checked)
            {
                typeCheck = 4; 
            }
        }

        private void FrmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát? Thoát là hối hận lắm đấy :(", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khônng ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtTìmKiếm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTìmKiếm.PerformClick();
            }
        }

        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDanhSachNhanVien.Rows[e.RowIndex];
            txtMSNV.Text = row.Cells[0].Value.ToString();
            txtHọNV.Text = row.Cells[1].Value.ToString();
            txtTênNV.Text = row.Cells[2].Value.ToString();
            txtSoDienThoai.Text = row.Cells[3].Value.ToString();
            dtpNgaySinh.Text = row.Cells[4].Value.ToString();
            dtpNgayVaoLam.Text = row.Cells[5].Value.ToString();
            txtChứcVụ.Text = row.Cells[6].Value.ToString();
            txtLươngTháng.Text = row.Cells[7].Value.ToString();
            txtGiớiTính.Text = row.Cells[8].Value.ToString();
            txtSốCMND.Text = row.Cells[9].Value.ToString();
            txtDiaChiThuongTru.Text = row.Cells[10].Value.ToString();
            txtEmail.Text = row.Cells[11].Value.ToString();


        }
      
        
    }
}

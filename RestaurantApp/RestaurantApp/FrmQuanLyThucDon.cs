using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using BUS;
using DTO;

namespace RestaurantApp
{
    public partial class FrmQuanLyThucDon : Form
    {
        BUS_DanhMuc Dm = new BUS_DanhMuc();
        BUS_MonAn Ma = new BUS_MonAn();
        BUS_ChiTietMonAn Ct = new BUS_ChiTietMonAn();
        BUS_NguyenLieu Nl = new BUS_NguyenLieu();

        public FrmQuanLyThucDon()
        {
            InitializeComponent();
        }

        private void FrmQuanLyThucDon_Load(object sender, EventArgs e)
        {
            getDanhMuc();
            getMonAn();
            getChiTietMonAn();
            getCombobox();
            this.dgvCongThuc.ClearSelection();//ClearSelection() : Xoa focus khi hien datagridview
            this.dgvDanhMuc.ClearSelection();
            this.dgvMonAn.ClearSelection();
        }
        private void getDanhMuc() //Ham nay de hien thi bang len datagrid view
        {
            DataSet ds = Dm.getDanhMuc();
            dgvDanhMuc.DataSource = ds.Tables[0];// bang ao nay duoc do vao dgvDanhMuc
        }
        private void getMonAn()
        {
            DataSet ds = Ma.getMonAn();
            dgvMonAn.DataSource = ds.Tables[0];// bang ao nay duoc do vao dgvMonAn
            dgvMonAn.Columns[2].DefaultCellStyle.Format = "#,0.# VNÐ";// dinh dang lai tien hien thi tren gridviewMonAn
        }
        private void getChiTietMonAn()
        {

            DataSet ds = Ct.getChiTietMonAn();
            dgvCongThuc.DataSource = ds.Tables[0];

            dgvCongThuc.Columns[3].Visible = false;//ẩn cột MaMonAn
            dgvCongThuc.Columns[4].Visible = false;//ẩn cột MaNguyenLieu
        }
        private void getCombobox()
        {
            //combobox mon an
            DataSet ds = Ma.getMonAn();
            cbbTenMonAn.DataSource = ds.Tables[0];
            cbbTenMonAn.DisplayMember = "TenMonAn";
            cbbTenMonAn.ValueMember = "MaMonAn";
            ds = null;
            //combobox nguyen lieu
            ds = Nl.getNguyenLieu();
            cbbTenNguyenLieu.DataSource = ds.Tables[0];
            cbbTenNguyenLieu.DisplayMember = "TenNL";
            cbbTenNguyenLieu.ValueMember = "MaNguyenLieu";
        }
        private void btnThemNhom_Click(object sender, EventArgs e)
        {

            try
            {
                DTO_DanhMuc dm = new DTO_DanhMuc(txtTenDanhMuc.Text, txtMoTa.Text);
                if (Dm.ThemDanhMuc(dm) == 1)
                {
                    getDanhMuc();

                    MessageBox.Show("Thêm danh mục [" + txtTenDanhMuc.Text + "] thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Tên danh mục không được để trống!Thêm không thành công!");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chăc chắn xóa món này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtMaDanhMuc.Text != "")
                    {
                        BUS_DanhMuc busDanhMuc = new BUS_DanhMuc();
                        DTO_DanhMuc dm = new DTO_DanhMuc(int.Parse(txtMaDanhMuc.Text));
                        busDanhMuc.XoaDanhMuc(dm);
                        getDanhMuc();//refresh lai bang danh muc       
                        if (txtTenDanhMuc.Text == txtTenDanhMuc.Text)

                            MessageBox.Show("Xóa danh mục [" + txtTenDanhMuc.Text + "] " + "thành công!", "Thông báo", MessageBoxButtons.OK);

                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn hàng danh mục để xóa!", "Thông báo", MessageBoxButtons.OK);
                    }
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Danh mục còn tồn tại trong món ăn, Xóa danh mục không thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnSuaNhom_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDanhMuc.Text != "")
                {
                    DTO_DanhMuc dm = new DTO_DanhMuc(int.Parse(txtMaDanhMuc.Text), txtTenDanhMuc.Text, txtMoTa.Text);
                    Dm.SuaDanhMuc(dm);
                    getDanhMuc();//refresh lai Danh Muc
                    MessageBox.Show("Sửa danh mục [" + txtMaDanhMuc.Text + "] thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn hàng danh mục để sửa!", "Thông báo", MessageBoxButtons.OK);
                }
            }

            catch (SqlException ex)
            {

                throw ex;
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDanhMuc.Text != "")
                {
                    if (txtTenMonAn.Text == "" || txtGiaTien.Text == "" || txtDonViTinhtd.Text == "")
                    {
                        MessageBox.Show("Phải nhập đủ tên món ăn, giá và đơn vị tính!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else if (txtTenMonAn.Text != "" && txtGiaTien.Text != "" && txtDonViTinhtd.Text != "")
                    {
                        DTO_MonAn ma = new DTO_MonAn(txtTenMonAn.Text, int.Parse(txtGiaTien.Text), int.Parse(txtMaDanhMuc.Text), txtDonViTinhtd.Text);
                        BUS_MonAn busMonAn = new BUS_MonAn();
                        busMonAn.ThemMonAn(ma);
                        getMonAn();
                        MessageBox.Show("Thêm món [" + txtTenMonAn.Text + "] thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    getCombobox();//load lai combobox MonAn
                }
                else
                {
                    MessageBox.Show("Bạn phải xếp món ăn vào 1 danh mục có sẵn!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMonAn.Text != "")
                {
                    BUS_MonAn ma = new BUS_MonAn();
                    DTO_MonAn dm = new DTO_MonAn(int.Parse(txtMaMonAn.Text), txtTenMonAn.Text, int.Parse(txtGiaTien.Text), int.Parse(txtMaDanhMuc.Text), txtDonViTinhtd.Text);
                    ma.SuaMonAn(dm);
                    getMonAn();//refresh lai Danh Muc
                    MessageBox.Show("Sửa món [" + txtMaMonAn.Text + "] thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn hàng món ăn để sửa!", "Thông báo", MessageBoxButtons.OK);
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Bạn có chăc chắn xóa món này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtMaMonAn.Text != "")
                    {
                        BUS_MonAn ma = new BUS_MonAn();
                        DTO_MonAn dm = new DTO_MonAn(int.Parse(txtMaMonAn.Text));
                        ma.XoaMonAn(dm);
                        getMonAn();
                        MessageBox.Show("Xóa món [" + txtTenMonAn.Text + "] thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn hàng để xóa! Xóa không thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Món ăn còn tồn tại trong công thức,Xóa không thành công!", "Thông báo", MessageBoxButtons.OK); 
            }
        }
        private void btnThemCongThuc_Click(object sender, EventArgs e)
        {

            string maMonAn = cbbTenMonAn.SelectedValue.ToString().Trim();
            string maNguyenLieu = cbbTenNguyenLieu.SelectedValue.ToString().Trim();//lay ma mon an trong bang mon an
            string ghiChu = txtGhiChu.Text;
            DTO_ChiTietMonAn ct = new DTO_ChiTietMonAn(Convert.ToInt32(maMonAn), Convert.ToInt32(maNguyenLieu), ghiChu);
            try
            {
                Ct.ThemCongThuc(ct);
                MessageBox.Show("Thêm nguyên liệu " + cbbTenNguyenLieu.GetItemText(cbbTenNguyenLieu.SelectedItem).Trim() + " vào " + cbbTenMonAn.GetItemText(cbbTenMonAn.SelectedItem).Trim() + " thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlException)
            {
                MessageBox.Show("Công thức món ăn đã tồn tại!", "Thông báo");
            }
            getChiTietMonAn();
        }
        private void btnXoaCongThuc_Click(object sender, EventArgs e)
        {
            try
            {
                string a = dgvCongThuc.Rows[index].Cells[0].Value.ToString().Trim();
                string b = dgvCongThuc.Rows[index].Cells[1].Value.ToString().Trim();
                
                if (lblMaMonAn.Text != "")
                {
                    if (MessageBox.Show("Bạn có chăc chắn xóa công thức này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BUS_ChiTietMonAn chitiet = new BUS_ChiTietMonAn();
                        DTO_ChiTietMonAn dm = new DTO_ChiTietMonAn(int.Parse(lblMaMonAn.Text), int.Parse(lblMaNguyenLieu.Text));
                        chitiet.XoaCongThuc(dm);
                        getChiTietMonAn();
                        MessageBox.Show("Xóa công thức " + a + "[" + b + "] thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn hàng để xóa! Xóa không thành công!", "Thông báo", MessageBoxButtons.OK);
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int index;
        private void dgvDanhMuc_Click(object sender, EventArgs e)
        {
            index = dgvDanhMuc.CurrentRow.Index;
            txtMaDanhMuc.Text = dgvDanhMuc.Rows[index].Cells[0].Value.ToString().Trim();
            txtTenDanhMuc.Text = dgvDanhMuc.Rows[index].Cells[1].Value.ToString().Trim();
            txtMoTa.Text = dgvDanhMuc.Rows[index].Cells[2].Value.ToString().Trim();
        }
        private void dgvMonAn_Click(object sender, EventArgs e)
        {
            index = dgvMonAn.CurrentRow.Index;
            txtMaMonAn.Text = dgvMonAn.Rows[index].Cells[0].Value.ToString().Trim();
            txtTenMonAn.Text = dgvMonAn.Rows[index].Cells[1].Value.ToString().Trim();
            txtGiaTien.Text = String.Format("{0:0}", dgvMonAn.Rows[index].Cells[2].Value);
            txtDonViTinhtd.Text = dgvMonAn.Rows[index].Cells[3].Value.ToString().Trim();
            txtTenDanhMuc.Text = dgvMonAn.Rows[index].Cells[4].Value.ToString().Trim();
            txtMaDanhMuc.Text = dgvMonAn.Rows[index].Cells[5].Value.ToString().Trim();
        }

        private void dgvCongThuc_Click(object sender, EventArgs e)
        {
            index = dgvCongThuc.CurrentRow.Index;
            lblMaMonAn.Text = dgvCongThuc.Rows[index].Cells[3].Value.ToString().Trim();
            lblMaNguyenLieu.Text = dgvCongThuc.Rows[index].Cells[4].Value.ToString().Trim();
        }
        //ham nay de rang buot nhap chi nhap so vao o gia tien
        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Giá tiền là kí tự số ", "Thông Báo ", MessageBoxButtons.OK);
            }
        }
    }
}

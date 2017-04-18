using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class FrmTienIch : Form
    {
        const double USA = 22606.11;
        const double EUR = 24158.2955;
        const double JPY = 207.68;
        public FrmTienIch()
        {
            InitializeComponent();
        }
        private void FrmTienIch_Load(object sender, EventArgs e)
        {
            btnChuyenDoi.Enabled = false;
        }
        private double DoiTien()
        {
            double result = 0;
            double giatri = double.Parse(txtGiaTri.Text);
            if (cbb1.SelectedIndex == 0)
            {
                if (cbb2.SelectedIndex == 0)
                    result = giatri / USA;
                else if (cbb2.SelectedIndex == 1)
                    result = giatri / EUR;
                else if (cbb2.SelectedIndex == 2)
                    result = giatri / JPY;
            }
            return result;
        }
        private double DoiNguocLai()
        {
            double result = 0;
            double giatri = double.Parse(txtGiaTri.Text);
            if (cbb1.SelectedIndex == 0)
            {
                if (cbb2.SelectedIndex == 0)
                    result = giatri * USA;
                else if (cbb2.SelectedIndex == 1)
                    result = giatri * EUR;
                else if (cbb2.SelectedIndex == 2)
                    result = giatri * JPY;
            }
            return result;
        }

        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnDoiChieu.Text == "==>")
                    txtKetQua.Text = DoiTien().ToString().Trim();
                else if(btnDoiChieu.Text == "<==")
                    txtKetQua.Text = DoiNguocLai().ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập giá trị để chuyển đổi", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đóng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();

        }

        private void txtGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtGiaTri.Text != null)
            {
                btnChuyenDoi.Enabled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Giá tiền là kí tự số ", "Thông Báo ", MessageBoxButtons.OK);
            }

        }

        private void btnDoiChieu_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "";
            if (btnDoiChieu.Text == "==>")
                btnDoiChieu.Text = "<==";
            else 
                btnDoiChieu.Text = "==>";
        }

    }
}

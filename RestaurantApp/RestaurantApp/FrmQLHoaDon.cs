using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

using DAO;
using BUS;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace RestaurantApp
{
    public partial class FrmQuanLyHoaDon : Form
    {
        #region Quan ly ham
        private void _KhoiTao()
        {
            try
            {
                ltvTenSanPham.Items.Clear();
                ltvThanhTien.Items.Clear();
            }
            catch (Exception)
            {

            }
        }

        public static string _DoiSoSangDonViTienTe(object _object)
        {
            try
            {
                if (_object.ToString().Trim().Length == 0)
                { return " "; }

                if (_object.ToString() == "0")
                {
                    return "0,000";
                }

                decimal dThanhTien = Convert.ToDecimal(_object);
                string strThanhTien = string.Format("{0:#,#.}", dThanhTien);
                return strThanhTien;
            }
            catch (Exception)
            {

            }
            return "0.000";
        }

        private void _TongTien()
        {
            try
            {
                if (ltvThanhTien.Items.Count == 0)
                    return;

                float ThanhTien = 0;
                float TongTien = 0;
                for (int i = 0; i < ltvThanhTien.Items.Count; i++)
                {
                    ThanhTien = Convert.ToSingle(ltvThanhTien.Items[i].ToString().Replace(",", ""));
                    TongTien = TongTien + ThanhTien;
                }
                nudTongTien.Value = Convert.ToDecimal(TongTien);

                nudTienMat_ValueChanged(null, null);
            }
            catch (Exception)
            {

            }
        }
        #endregion
        #region Quan ly form
        public FrmQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _KhoiTao();
            getdanhsach();
            DataSet ds = getCombobox();
            cbbMonAnVaBan.DataSource = ds.Tables[0];
            cbbMonAnVaBan.DisplayMember = "Maban";
            cbbMonAnVaBan.ValueMember = "Maban";
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                Opacity = 100;
            }
        }

        #endregion
        #region Thao tac
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
               
                int index = dgvMonAnVaban.RowCount;//dem so dong trong datagrid view

                for (int i = 0; i <= index; i++)
                {
                    string TenMon = dgvMonAnVaban.Rows[i].Cells[2].Value.ToString().Trim();
                    string GiaTien = dgvMonAnVaban.Rows[i].Cells[3].Value.ToString().Trim();
                    ltvTenSanPham.Items.Add(TenMon);
                    string Tam = _DoiSoSangDonViTienTe(GiaTien);
                    ltvThanhTien.Items.Add(Tam);
                     _TongTien();
                }  
            }
            catch (Exception)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = ltvTenSanPham.SelectedIndex;
                ltvTenSanPham.Items.RemoveAt(Index);
                ltvThanhTien.Items.RemoveAt(Index);
                _TongTien();
            }
            catch (Exception)
            {

            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog PrintDialog = new PrintDialog();
                PrintDocument PrintDocument = new PrintDocument();

                PrintDialog.Document = PrintDocument; //add the document to the dialog box

                PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing
                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                DialogResult result = PrintDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PrintDocument.Print();
                }
            }
            catch (Exception)
            {

            }
        }

        private void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;
            graphic.DrawString("Hóa đơn thanh toán", new Font("Courier New", 17), new SolidBrush(Color.Black), startX  + 10, startY);
            string top = "Tên Sản Phẩm".PadRight(24) + "Thành Tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            int index = 0;
            foreach (string item in ltvTenSanPham.Items)
            {
                graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(ltvThanhTien.Items[index++].ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            }

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("TỔNG TIỀN TRẢ ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudTongTien.Value), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN MẶT ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudTienMat.Value), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN TRẢ ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudTienTra.Value), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Xin chân thành cảm ơn quý khách!", font, new SolidBrush(Color.Black), startX + 10, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("HẸN GẶP LẠI!", font, new SolidBrush(Color.Black), startX + 20, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("1 sp của sv OU!", font, new SolidBrush(Color.Black), startX + 10, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent  
        }

        private void lsbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltvThanhTien.SelectedIndex = ltvTenSanPham.SelectedIndex;
        }

        private void lsbThanhTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltvTenSanPham.SelectedIndex = ltvThanhTien.SelectedIndex;
        }

        private void nudTienMat_ValueChanged(object sender, EventArgs e)
        {
            if (nudTienMat.Value > nudTongTien.Value)
            {
                nudTienTra.Value = nudTienMat.Value - nudTongTien.Value;
            }
        }
        #endregion

        public DataSet getMonAnVaBan()
        {
            DataProvider dp = new DataProvider();
            SqlConnection cnn = dp.getConnect();//Ham nay tra ve 1 chuoi ket noi
            string sqlMonAn = "SELECT * FROM MonAnvaBan";
            SqlDataAdapter da = new SqlDataAdapter(sqlMonAn, cnn);// van chuyen du lieu
            DataSet ds = new DataSet();//Tao 1 bang ao
            da.Fill(ds);//do du lieu vao bang ao
            return ds;
        }
        public DataSet getCombobox()
        {
            DataProvider dp = new DataProvider();
            SqlConnection cnn = dp.getConnect();//Ham nay tra ve 1 chuoi ket noi
            string sqlMonAn = "SELECT DISTINCT MaBan FROM MonAnvaBan";
            SqlDataAdapter da = new SqlDataAdapter(sqlMonAn, cnn);// van chuyen du lieu
            DataSet ds = new DataSet();//Tao 1 bang ao
            da.Fill(ds);//do du lieu vao bang ao
            return ds;
        }
        public DataSet timMonAnVaBan()
        {
            int MaBan = int.Parse(cbbMonAnVaBan.SelectedValue.ToString().Trim());
            DataProvider dp = new DataProvider();
            SqlConnection cnn = dp.getConnect();//Ham nay tra ve 1 chuoi ket noi
            string sqlMonAn = "SELECT *FROM MonAnvaBan WHERE MaBan = '"+ MaBan+ "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlMonAn, cnn);// van chuyen du lieu
            DataSet ds = new DataSet();//Tao 1 bang ao
            da.Fill(ds);//do du lieu vao bang ao
            return ds;
        }
        private void getdanhsach() //Ham nay de hien thi bang len datagrid view
        {
            DataSet ds = getMonAnVaBan();
            dgvMonAnVaban.DataSource = ds.Tables[0];// bang ao nay duoc do vao dgvDanhMuc
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataSet ds = timMonAnVaBan();
            dgvMonAnVaban.DataSource = ds.Tables[0];
        }
    }
}

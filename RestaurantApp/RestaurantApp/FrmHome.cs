﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using DTO;
using BUS;

namespace RestaurantApp
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  labNgayGio.Text = DateTime.Now.ToString("yy/mm/yyyy");
            //labGio.Text = DateTime.Now.ToString("HH:mm");
        }


        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}
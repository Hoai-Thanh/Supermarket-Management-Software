using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiaoDien_Tuan6
{
    public partial class ThongKeTonKho : Form
    {
        public ThongKeTonKho()
        {
            InitializeComponent();
        }

        private void ThongKeTonKho_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            ColumnHeader colSTT = new ColumnHeader();
            colSTT.Text = "STT";
            colSTT.Width = 100;
            ColumnHeader colMaNhanVien = new ColumnHeader();
            colMaNhanVien.Text = "Mã Sản Phẩm";
            colMaNhanVien.Width = 150;
            ColumnHeader colTenNhanVien = new ColumnHeader();
            colTenNhanVien.Text = "Tên Sản Phẩm";
            colTenNhanVien.Width = 150;
            ColumnHeader colNgaySinh = new ColumnHeader();
            colNgaySinh.Text = "Tháng";
            colNgaySinh.Width = 70;
            ColumnHeader colDiaChi = new ColumnHeader();
            colDiaChi.Text = "Năm";
            colDiaChi.Width = 70;
            ColumnHeader colDienThoai = new ColumnHeader();
            colDienThoai.Text = "Tồn Kho";
            colDienThoai.Width = 90;


            listView1.Columns.Add(colSTT);
            listView1.Columns.Add(colMaNhanVien);
            listView1.Columns.Add(colTenNhanVien);
            listView1.Columns.Add(colNgaySinh);
            listView1.Columns.Add(colDiaChi);
            listView1.Columns.Add(colDienThoai);
        }
    }
}

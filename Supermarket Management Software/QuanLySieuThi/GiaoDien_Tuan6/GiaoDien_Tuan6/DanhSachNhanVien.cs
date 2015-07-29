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
    public partial class DanhSachNhanVien : Form
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            ColumnHeader colSTT = new ColumnHeader();
            colSTT.Text = "STT";
            colSTT.Width = 50;
            ColumnHeader colMaNhanVien = new ColumnHeader();
            colMaNhanVien.Text = "Mã Nhân Viên";
            colMaNhanVien.Width = 100;
            ColumnHeader colTenNhanVien = new ColumnHeader();
            colTenNhanVien.Text = "Tên Nhân Viên";
            colTenNhanVien.Width = 100;
            ColumnHeader colNgaySinh = new ColumnHeader();
            colNgaySinh.Text = "Ngày Sinh";
            colNgaySinh.Width = 70;
            ColumnHeader colDiaChi = new ColumnHeader();
            colDiaChi.Text = "Địa Chỉ";
            colDiaChi.Width = 120;
            ColumnHeader colDienThoai = new ColumnHeader();
            colDienThoai.Text = "Điện Thoại";
            colDienThoai.Width = 70;
            ColumnHeader colChucVu = new ColumnHeader();
            colChucVu.Text = "Chức Vụ";
            colChucVu.Width = 70;


            listView1.Columns.Add(colSTT);
            listView1.Columns.Add(colMaNhanVien);
            listView1.Columns.Add(colTenNhanVien);
            listView1.Columns.Add(colNgaySinh);
            listView1.Columns.Add(colDiaChi);
            listView1.Columns.Add(colDienThoai);
            listView1.Columns.Add(colChucVu);
        }
    }
}

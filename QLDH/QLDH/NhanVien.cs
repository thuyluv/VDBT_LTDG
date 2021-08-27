using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDH
{
    public partial class NhanVien : Form
    {
        BUS_DonHang busNV;
        public NhanVien()
        {
            InitializeComponent();
            busNV = new BUS_DonHang();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
           

            CapNhatDataGridView1();
           

        }
        void CapNhatDataGridView1()
        {
            busNV.LayDSNhanVien(dGNhanVien);
            dGNhanVien.Columns[0].Width = (int)(0.2 * dGNhanVien.Width);
            dGNhanVien.Columns[1].Width = (int)(0.2 * dGNhanVien.Width);
            dGNhanVien.Columns[2].Width = (int)(0.2 * dGNhanVien.Width);
            dGNhanVien.Columns[3].Width = (int)(0.2 * dGNhanVien.Width);
            dGNhanVien.Columns[4].Width = (int)(0.2 * dGNhanVien.Width);
           


        }

        public string[] name(string str)
        {
            string[] arr = str.Split(' ');
            return arr;
        }

        public string[] arr { get; set; }
         private void btThem_Click(object sender, EventArgs e)
        {
            arr = name(txtHoten.Text);
            Employee NhanVien = new Employee();
            NhanVien.FirstName = arr[0];
            NhanVien.LastName = arr[1];
            //NhanVien.LastName = txtHoten.Text;
            //NhanVien.FirstName = txtHoten.Text;
            NhanVien.BirthDate = dtpNgaySinh.Value;
            NhanVien.HomePhone = txtDiaChi.Text;
            NhanVien.Address = txtDiaChi.Text;
            
            

            busNV.ThemNhanVien(NhanVien);
            //cap nhap lai datagridview
            dGNhanVien.Columns.Clear();
            //busNV.LayDSNhanVien(dGNhanVien);
            CapNhatDataGridView1();
          
       }

        private void dGNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex <dGNhanVien.Rows.Count)
            {


                txtHoten.Text = dGNhanVien.Rows[e.RowIndex].Cells["LastName"].Value.ToString() + " " + dGNhanVien.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtDiaChi.Text = dGNhanVien.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtDienThoai.Text = dGNhanVien.Rows[e.RowIndex].Cells["HomePhone"].Value.ToString();
                dtpNgaySinh.Text = dGNhanVien.Rows[e.RowIndex].Cells["BirthDate"].Value.ToString();

            }

        }
      

        //private void btXoa_Click(object sender, EventArgs e)
        //{
        //    dGNhanVien.CurrentRow.Cells["EmployeeID"].Value.ToString();
        //    dGNhanVien.Columns.Clear();
        //    CapNhatDataGridView();
        //}

        private void btThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban muon thoat");
            Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Employee nhanvien = new Employee();

            //Sua
            arr = name(txtHoten.Text);
            nhanvien.FirstName = arr[0];
            nhanvien.LastName = arr[1];
            //nhanvien.LastName = txtHoten.Text;
            //nhanvien.FirstName = txtHoten.Text;
            nhanvien.BirthDate = dtpNgaySinh.Value;
            nhanvien.Address = txtDiaChi.Text;
            nhanvien.HomePhone = txtDienThoai.Text;

            busNV.SuaNV(nhanvien);
            //cap nhap lai 
            dGNhanVien.Columns.Clear();
            CapNhatDataGridView1();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Employee nhanvien = new Employee();

            arr = name(txtHoten.Text);
            nhanvien.FirstName = arr[0];
            nhanvien.LastName = arr[1];
            //nhanvien.LastName = txtHoten.Text;
            //nhanvien.FirstName = txtHoten.Text;
            nhanvien.BirthDate = dtpNgaySinh.Value;
            nhanvien.Address = txtDiaChi.Text;
            nhanvien.HomePhone = txtDienThoai.Text;

            //goi xoa ben bus
            busNV.XoaNV(nhanvien);
            //cap nhap lai
            dGNhanVien.Columns.Clear();
            CapNhatDataGridView1();

        }
    }
}

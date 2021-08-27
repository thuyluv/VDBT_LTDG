using System;
using System.Windows.Forms;

namespace QLDH
{
    public partial class QLDH : Form
    {
        BUS_DonHang busDH;
        public QLDH()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }

        private void QLDH_Load(object sender, EventArgs e)
        {
            //busDH.LayDSDonHang(gVDH);
            busDH.DSKH(cbKhachHang);
            busDH.DSNV(cbNhanVien);
            //busDH.LayDSDonHang(gVDH);
            CapNhatGV();
        }


        private void gVDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.RowIndex < gVDH.Rows.Count)
            {
                txtMaDH.Enabled = false;
                cbKhachHang.Text = gVDH.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbNhanVien.Text = gVDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMaDH.Text = gVDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                dtpNgayDH.Text = gVDH.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        void CapNhatGV()
        {
            busDH.DSDonHang(gVDH);
            //Chinh kich thuoc
            gVDH.Columns[0].Width = (int)(gVDH.Width * 0.2);
            gVDH.Columns[1].Width = (int)(gVDH.Width * 0.2);
            gVDH.Columns[2].Width = (int)(gVDH.Width * 0.2);
            gVDH.Columns[3].Width = (int)(gVDH.Width * 0.3);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //txtMaDH.Enabled = true;
            Order donHang = new Order();
            donHang.OrderDate = dtpNgayDH.Value;
            //donHang.OrderID = int.Parse(txtMaDH.Text);
            donHang.EmployeeID=int.Parse(cbNhanVien.SelectedValue.ToString());
            donHang.CustomerID = cbKhachHang.SelectedValue.ToString();

            busDH.ThemDonHang(donHang);
            //cap nhap lai datagridview

            gVDH.Columns.Clear();
            CapNhatGV();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Order donHang = new Order();
            //Sua
            donHang.OrderID = int.Parse(txtMaDH.Text);
            donHang.OrderDate = dtpNgayDH.Value;
            donHang.EmployeeID = int.Parse(cbNhanVien.SelectedValue.ToString());
            donHang.CustomerID = cbKhachHang.SelectedValue.ToString();

            busDH.SuaDH(donHang);
            gVDH.Columns.Clear();
            CapNhatGV();

        }

        private void gVDH_DoubleClick(object sender, EventArgs e)
        {
            CTDH c = new CTDH();
            c.maDH = int.Parse(gVDH.CurrentRow.Cells["OrderID"].Value.ToString());
            c.ShowDialog();
        }

        private void ThemCTDH_Click(object sender, EventArgs e)
        {
            FDatHang f = new FDatHang();
            f.maDH = int.Parse(gVDH.CurrentRow.Cells[0].Value.ToString());
            f.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Order donHang = new Order();
            
            //Xoa
            //donHang.OrderID = int.Parse(txtMaDH.Text);
            //donHang.OrderDate = dtpNgayDH.Value;
            //donHang.EmployeeID = int.Parse(cbNhanVien.SelectedValue.ToString());
            //donHang.CustomerID = cbKhachHang.SelectedValue.ToString();


            busDH.XoaDH(donHang);
            //cap nhap datagridview
            gVDH.Columns.Clear();
            CapNhatGV();

        }
    }
}

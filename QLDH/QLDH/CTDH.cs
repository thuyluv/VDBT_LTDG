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
    public partial class CTDH : Form
    {
        public int maDH;
        BUS_DonHang busDH;
        public CTDH()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }

        private void CTDH_Load(object sender, EventArgs e)
        {

            txtMaDH.Text = maDH.ToString();
            //busDH.LayCTDH(maDH, gVCTDH);
            CapNhatGV2();
        }

        private void gVCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVCTDH.Rows.Count)
            {
                txtMaDH.Enabled = false;
                txtMaSP.Text = gVCTDH.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtMaDH.Text = gVCTDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                txtDonGia.Text = gVCTDH.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                txtSoLuong.Text = gVCTDH.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            }
        }

        void CapNhatGV2()
        {
            busDH.LayCTDH(maDH,gVCTDH);
            //Chinh kich thuoc
            gVCTDH.Columns[0].Width = (int)(gVCTDH.Width * 0.2);
            gVCTDH.Columns[1].Width = (int)(gVCTDH.Width * 0.2);
            gVCTDH.Columns[2].Width = (int)(gVCTDH.Width * 0.2);
            gVCTDH.Columns[3].Width = (int)(gVCTDH.Width * 0.3);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
            Order_Detail od = new Order_Detail();
            od.OrderID = int.Parse(txtMaDH.Text);
            od.ProductID = int.Parse(txtMaSP.Text);
            od.UnitPrice = decimal.Parse(txtDonGia.Text);
            od.Quantity = short.Parse(txtSoLuong.Text);




            busDH.ThemCTDonHang(od);
            //cap nhap lai datagridview

            gVCTDH.Columns.Clear();
            CapNhatGV2();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Order_Detail donhang = new Order_Detail();

            donhang.OrderID = int.Parse(txtMaDH.Text);
            donhang.ProductID = int.Parse(txtMaSP.Text);
            donhang.UnitPrice = decimal.Parse(txtDonGia.Text);
            donhang.Quantity = short.Parse(txtSoLuong.Text);


            busDH.SuaCTDH(donhang);

            gVCTDH.Columns.Clear();
            CapNhatGV2();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Order_Detail donhang1 = new Order_Detail();

            donhang1.OrderID = int.Parse(txtMaDH.Text);
            donhang1.ProductID = int.Parse(txtMaSP.Text);
            donhang1.UnitPrice = decimal.Parse(txtDonGia.Text);
            donhang1.Quantity = short.Parse(txtSoLuong.Text);


            busDH.XoaCTDH(donhang1);

            //gVCTDH.Columns.Clear();
            CapNhatGV2();
        }
    }
}

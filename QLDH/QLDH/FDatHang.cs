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
    public partial class FDatHang : Form
    {
        BUS_DonHang busDH;
        public FDatHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }
        public int maDH;
        bool co = false;
        DataTable dtSanPham;

        private void FDatHang_Load(object sender, EventArgs e)
        {
            txtMaDH.Text = maDH.ToString();
            busDH.LayDSSP(cbSP);
            co = true;

            //Load 4 cot len datatable
            dtSanPham = new DataTable();
            dtSanPham.Columns.Add("ProductID");
            dtSanPham.Columns.Add("UnitPrice");
            dtSanPham.Columns.Add("Quantity");
            dtSanPham.Columns.Add("Discount");

            dGSP.DataSource = dtSanPham;
            dGSP.Columns[0].Width = (int)(dGSP.Width * 0.2);
            dGSP.Columns[1].Width = (int)(dGSP.Width * 0.2);
            dGSP.Columns[2].Width = (int)(dGSP.Width * 0.2);
            dGSP.Columns[3].Width = (int)(dGSP.Width * 0.2);


        }
        void HienThiThongTinSanPham(string maSP)
        {
            int ma = int.Parse(maSP);
            Product s = busDH.HienThiDSSP(ma);
            txtDonGia.Text = s.UnitPrice.ToString();
            txtLoaiSP.Text = s.CategoryID.ToString();
            txtNhaCC.Text = s.SupplierID.ToString();
        }

        private void cbSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co)
            {
                HienThiThongTinSanPham(cbSP.SelectedValue.ToString());
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bool tragThai = true;
            foreach (DataRow item in dtSanPham.Rows)
            {
                if (item[0].ToString() == cbSP.SelectedValue.ToString())
                {
                    tragThai = false;
                    item[2] = int.Parse(item[2].ToString()) + numSoLuong.Value;
                }
            }
                if (tragThai)
                {
                    DataRow r = dtSanPham.NewRow();
                    r[0] = cbSP.SelectedValue.ToString();
                    r[1] = txtDonGia.Text;
                    r[2] = numSoLuong.Value.ToString();
                    r[3] = txtGiamGia.Text;

                    dtSanPham.Rows.Add(r);
                }
            }

        private void dGSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex<dGSP.Rows.Count)
            {
                txtMaDH.Text = dGSP.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtDonGia.Text= dGSP.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                numSoLuong.Value = decimal.Parse(dGSP.Rows[e.RowIndex].Cells["Quantity"].Value.ToString());
                //txtNhaCC.Text=dGSP.Rows[e.RowIndex].Cells["CategoryID"].Value.ToString();
                //txtLoaiSP.Text = dGSP.Rows[e.RowIndex].Cells["SupplierID"].Value.ToString();
                

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Order_Detail sanpham = new Order_Detail();

            sanpham.ProductID = int.Parse(txtMaDH.Text);
            sanpham.UnitPrice =decimal.Parse(txtDonGia.Text);
            sanpham.Quantity = short.Parse(numSoLuong.Value.ToString());

            busDH.SuaDMSP(sanpham);

            //cap nhap datagridview
            dGSP.Columns.Clear();
            busDH.LayDSSP(cbSP) ;

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Order_Detail sanpham = new Order_Detail();

            sanpham.ProductID = int.Parse(txtMaDH.Text);
            sanpham.UnitPrice = decimal.Parse(txtDonGia.Text);
            sanpham.Quantity = short.Parse(numSoLuong.Value.ToString());

            busDH.XoaDMSP(sanpham);

            //cap nhap datagridview
            dGSP.Columns.Clear();
            busDH.LayDSSP(cbSP);

        }
    }
    }
    


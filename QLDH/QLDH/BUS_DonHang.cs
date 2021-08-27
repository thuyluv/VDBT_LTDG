using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDH
{
    class BUS_DonHang
    {
        DAO_DonHang da;
        //lien ket duoc file daoSP
        DAO_DMSanPham ds;
        DAO_NhanVien da1;
        
        public BUS_DonHang()
        {
            da = new DAO_DonHang();
            ds = new DAO_DMSanPham();
            da1 = new DAO_NhanVien();
        }
        //public void LayDSDonHang(DataGridView dg)
        //{
        //    dg.DataSource = da.LayDSDonHang3();

        //}
        public void LayDSNhanVien(DataGridView dg)
        {
            dg.DataSource = da1.LayDSNV();

        }

        //dem dl vo datagridview
        public void DSDonHang(DataGridView dg)
        {
            dg.DataSource = da.LayDSDonHang3();

        }
        public void DSKH(ComboBox cb)
        {
            cb.DataSource = da.LayDSKH();
            cb.DisplayMember = "CompanyName";
            cb.ValueMember = "CustomerID";
        }
        //Dem tuw datagridview len combobox
        public void DSNV(ComboBox cb)
        {
            cb.DataSource = da.LayDSNV();
            cb.DisplayMember = "LastName";
            cb.ValueMember = "EmployeeID";
        }
        public void ThemDonHang(Order DonHang)
        {
            try
            {

                da.ThemDonHang(DonHang);
                //Xu ly khi kiem tra them thanh cong
            }
            catch (Exception)
            {
                MessageBox.Show("Loi"); ;

            }
        }



        public void SuaDH(Order dh)
        {
            if(da.SuaDH(dh))
            {
                MessageBox.Show("Sua thanh cong");
            }
            else
            {
                MessageBox.Show("Loi khong co don hang");
            }
        }

        //xoa dh
        public void XoaDH(Order dh)
        {
            if (da.XoaDH(dh))
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Loi khong co don hang");
            }
        }

        //QUA FORM CTDH

        public void LayCTDH(int maDH, DataGridView dg)
        {
            dg.DataSource = da.LayCTDH(maDH);
        }
        public void ThemCTDonHang(Order_Detail CTDonHang)
        {
            try
            {

                da.ThemCTDonHang(CTDonHang);
                //Xu ly khi kiem tra them thanh cong
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi" + e.Message);

            }
        }
        //SUA CTDH
        public void SuaCTDH(Order_Detail dh)
        {
            if (da.SuaCTDH(dh))
            {
                MessageBox.Show("Sua thanh cong");
            }
            else
            {
                MessageBox.Show("Loi khong co ct don hang");
            }
        }

        //XOA CTDH

        public void XoaCTDH(Order_Detail dh)
        {
            if (da.XoaCTDH(dh))
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Loi khong co ma don hang");
            }
        }

        //FORM DMSP
        public void LayDSSP(ComboBox cb)
        {
            cb.DataSource = ds.LayDSSanPham();
            cb.DisplayMember = "ProductName";
            cb.ValueMember = "ProductID";
        }

        public Product HienThiDSSP(int maSP)
        {
            Product s = ds.LayThongTinSanPham2(maSP);
            return s;
        }



        //  FORM NHAN VIEN
        public void ThemNhanVien(Employee NhanVien)
        {
            try
            {
                da1.ThemNhanVien(NhanVien);
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
        }
        
        public void SuaNV(Employee nv)
        {
            if(da1.SuaNV(nv))
            {
                MessageBox.Show("Sua thanh cong");
            }
            else
            {
                MessageBox.Show("Loi khong co  nhan vien");
            }
        }

        //xoa nhan vien
        public void XoaNV(Employee nhanvien)
        {
            if (da1.XoaNV(nhanvien))
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Loi khong co  nhan vien");
            }
        }

        //FORM DMSP
        //SUA DMSP
        public void SuaDMSP(Order_Detail dh)
        {
            if (ds.SuaDMSanPham(dh))
            {
                MessageBox.Show("Sua thanh cong");
            }
            else
            {
                MessageBox.Show("Loi khong co ma don hang");
            }
        }

        //XOA DMSP

        public void XoaDMSP(Order_Detail sp)
        {
            if (ds.XoaDMSanPham(sp))
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Loi khong co ma don hang");
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDH
{
    class DAO_DMSanPham
    {
        public NWDataContext db;
        public DAO_DMSanPham()
        {
            db = new NWDataContext();
        }

        public dynamic LayDSSanPham()
        {
            var ds = db.Products
                .Select(s => new
                {
                    s.ProductID,
                    s.ProductName
                });
            return ds;
        }

        public Product LayThongTinSanPham2(int maSP)
        {
            var sp = db.Products
                .FirstOrDefault(s => s.ProductID == maSP);
            return sp;
        }
        //SUA DMSP

        public bool SuaDMSanPham(Order_Detail sanpham)
        {
            bool trangThai = false;
            Order_Detail d = new Order_Detail();
            try
            {

                d = db.Order_Details.First(s => s.ProductID == sanpham.ProductID);
                trangThai = true;
                d.ProductID = sanpham.ProductID;
                d.UnitPrice= sanpham.UnitPrice;
                d.Quantity = sanpham.Quantity;

                db.SubmitChanges();
            }
            catch (Exception)
            {
                trangThai = false;
            }
            return trangThai;
        }

        //XOA DMSP
        public bool XoaDMSanPham(Order_Detail sanpham)
        {
            bool TrangThai = false;
            Order_Detail w = new Order_Detail();

            try
            { 
                w = db.Order_Details.First(s => s.ProductID == sanpham.ProductID);
                
                w.ProductID = sanpham.ProductID;
                w.UnitPrice = sanpham.UnitPrice;
                w.Quantity = sanpham.Quantity;

                db.Order_Details.DeleteOnSubmit(w);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                TrangThai = false;

            }
            return TrangThai;
        }
    }
}

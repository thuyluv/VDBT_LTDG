using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDH
{
    
    class DAO_DonHang
    {
        NWDataContext db;
        public DAO_DonHang()
        {
            db = new NWDataContext();

        }

        public IEnumerable<Order> LayDSDonHang()
        {
            var dsDH = from i in db.Orders select i;
            return dsDH;
        }

        public dynamic LayDSDonHang3()
        {
            dynamic dsDH = db.Orders.Select(s => new
            {
               
                s.OrderID,
                s.OrderDate,
                s.Employee.LastName,
                s.Customer.CompanyName
                //s.CustomerID



            }) ;
            return dsDH;
        }

       
          
        //lay du lieu dem vo datagridview(lay 1 vi thuoc tinh =>dynamic)
        public dynamic LayDSKH()
        {
            var ds = db.Customers.Select(k => new
            {
                k.CustomerID,
                k.CompanyName,
            });
            return ds;
        }

        public dynamic LayDSNV()
        {
            var ds = db.Employees.Select(k => new
            {

                k.EmployeeID,
                k.LastName,
                k.BirthDate,
                k.HomePhone,
                k.Address


            });
            return ds;
        }

        public void ThemDonHang(Order donHang)
        {
            db.Orders.InsertOnSubmit(donHang);
            db.SubmitChanges();
        }

        public bool SuaDH(Order donHang)
        {
            bool trangThai = false;
            Order d = new Order();
            try
            {
                
                d = db.Orders.First(s => s.OrderID == donHang.OrderID);
                trangThai = true;
                d.OrderDate = donHang.OrderDate;
                d.CustomerID = donHang.CustomerID;
                d.EmployeeID = donHang.EmployeeID;

                db.SubmitChanges();
            }
            catch(Exception)
            {
                trangThai = false;
            }
            return trangThai;
        }
        public bool XoaDH(Order donHang)
        {
            bool trangThai = false;
            // tim don hang neu co thi xoa
            Order d = new Order();
            try
            {

                d = db.Orders.First(s => s.OrderID == donHang.OrderID);
                trangThai = true;

                // xoa
                d.OrderID = donHang.OrderID;
                d.OrderDate = donHang.OrderDate;
                d.CustomerID = donHang.CustomerID;
                d.EmployeeID = donHang.EmployeeID;

               
                db.Orders.DeleteOnSubmit(d);

                db.SubmitChanges();
            }
            catch (Exception)
            {
                trangThai = false;
            }
            return trangThai;
        }

        //QUA FORM CTDH
        public dynamic LayCTDH(int maDH)
        {
            var ds = db.Order_Details
                .Where(s => s.OrderID == maDH)
                .Select(s => new
                {
                    s.OrderID,
                    s.ProductID,
                    s.Quantity,
                    s.UnitPrice

                });
            return ds;
        }

        //THEM CTDH
        public void ThemCTDonHang(Order_Detail CTdonHang)
        {
            db.Order_Details.InsertOnSubmit(CTdonHang);
            db.SubmitChanges();
        }
        //SUA CTDH

        public bool SuaCTDH(Order_Detail donHang)
        {
            bool trangThai = false;
            Order_Detail d = new Order_Detail();
            try
            {

                d = db.Order_Details.First(s => s.OrderID == donHang.OrderID);
                trangThai = true;
                d.OrderID = donHang.OrderID;
                d.ProductID = donHang.ProductID;
                d.Quantity = donHang.Quantity;
                d.UnitPrice = donHang.UnitPrice;

                db.SubmitChanges();
            }
            catch (Exception)
            {
                trangThai = false;
            }
            return trangThai;
        }


        //XOA CTDH
        public bool XoaCTDH(Order_Detail donHang)
        {
            bool trangThai = false;
            Order_Detail o = new Order_Detail();
            try
            {

                o = db.Order_Details.First(s => s.OrderID == donHang.OrderID);
                trangThai = true;
                o.OrderID = donHang.OrderID;
                o.ProductID = donHang.ProductID;
                o.Quantity = donHang.Quantity;
                o.UnitPrice = donHang.UnitPrice;

                db.Order_Details.DeleteOnSubmit(o);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                trangThai = false;
            }
            return trangThai;
        }
        ////public void ThemNhanVien(Employee NhanVien)
        //{
        //    db.Employees.InsertOnSubmit(NhanVien);
        //    db.SubmitChanges();
        //}

    }
}

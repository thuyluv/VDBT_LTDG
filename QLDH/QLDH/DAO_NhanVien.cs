using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDH
{
    class DAO_NhanVien
    {
        public NWDataContext db;
        public DAO_NhanVien()
        {
            db = new NWDataContext();
        }

        public dynamic LayDSNV()
        {
            var ds = db.Employees.Select(k => new
            {

               
                k.LastName,
                k.FirstName,
                k.BirthDate,
                k.HomePhone,
                k.Address


            });
            return ds;
        }

        public void ThemNhanVien(Employee NhanVien)
        {
            db.Employees.InsertOnSubmit(NhanVien);
            db.SubmitChanges();
        }

        public bool SuaNV(Employee nhanvien)
        {
            bool TrangThai = false;
            try
            {
                Employee e = new Employee();

                e = db.Employees.First(s => s.EmployeeID == nhanvien.EmployeeID );

                TrangThai = true;

                //Neu tim thay nhan vien bawt dau sua

                e.LastName = nhanvien.LastName;
                e.FirstName = nhanvien.FirstName;
                e.BirthDate = nhanvien.BirthDate;
                e.Address = nhanvien.Address;
                e.HomePhone = nhanvien.HomePhone;

                db.SubmitChanges();
            }
            catch(Exception)
            {
                TrangThai = false;
            }
            return TrangThai;
        }

        public bool XoaNV(Employee nhanvien)
        {
            bool TrangThai = false;
            try
            {
                Employee e = new Employee();
                e = db.Employees.First(s => s.EmployeeID == nhanvien.EmployeeID);

                TrangThai = true;

                //Neu tim thay nhan vien bawt dau xoa

                e.LastName = nhanvien.LastName;
                e.FirstName = nhanvien.FirstName;
                e.BirthDate = nhanvien.BirthDate;
                e.Address = nhanvien.Address;
                e.HomePhone = nhanvien.HomePhone;

                db.Employees.DeleteOnSubmit(e);
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

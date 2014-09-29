using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BALayer
{
   public class BAKhachHang
    {
       /// <summary>
       /// Xu Ly voi du lieu
       /// </summary>
       /// <returns></returns>
        public List<DKhachHang> XemDanhMucKhachHang()
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            var khachhang =
                from tp in db.KhachHangs
                select tp;
            List<DKhachHang> listkh = new List<DKhachHang>();
            foreach (var item in khachhang)
            {
                listkh.Add(new DKhachHang(item));
            }
            return listkh;
        }
       /// <summary>
       /// Convert khach hang va Dkhach hang de xu ly du lieu
       /// </summary>
       /// <param name="kh">Convert csdl </param>
       /// <returnst>tra ve khach hang trong KhachHang</returns>
        public KhachHang ConvertKhachHang(DKhachHang kh)
        {
            // Lay dl
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
           // Goi doi tuong khach hang

            KhachHang khang = new KhachHang();
            // Chuyen doi kieu du lieu giua KhachHang va DKhachHang de xu ly...
            khang.MaKH = kh.MaKH;
            khang.TenCty = kh.TenCty;
            khang.DiaChi = kh.DiaChi;
            khang.MaThanhPho = kh.MaThanhPho;
            khang.DienThoai = kh.DienThoai;
            return khang;

        }
        public void ThemKhachHang(DKhachHang kh)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            db.KhachHangs.Add(ConvertKhachHang(kh));
            db.SaveChanges();
        }
        public void XoaKhachHang(string Makh)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            var khachhang = db.KhachHangs.Single(o => o.MaKH == Makh);
            db.KhachHangs.Remove(khachhang);
            db.SaveChanges();
        }
        public void CapNhatKhachHang(DKhachHang kh)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            var x = from p in db.KhachHangs

                    where p.MaKH.Equals(kh.MaKH)
                    select p;
            var khachHangUpdate = x.First();
            khachHangUpdate.TenCty = kh.TenCty;
            khachHangUpdate.DiaChi = kh.DiaChi;
            khachHangUpdate.MaThanhPho = kh.MaThanhPho;
            khachHangUpdate.DienThoai = kh.DienThoai;
            db.SaveChanges();
        
        }
    }
}

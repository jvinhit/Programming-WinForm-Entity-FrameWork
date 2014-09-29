using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BALayer
{
    public class BAThanhPho
    {
        public List<DThanhPho> XemDanhMucThanhPho()
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            var x = from p in db.ThanhPhos
                    select p;
            List<DThanhPho> listtp = new List<DThanhPho>();
            foreach (var item in x)
            {
                listtp.Add(new DThanhPho(item));
            }
            return listtp;
        }
        public ThanhPho LayThanhPho(string MaTp)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            var x = from p in db.ThanhPhos
                    where p.MaThanhPho.Equals(MaTp)
                    select p;
            return x.ToList().First();
        }
        public ThanhPho ChuyenDoiThanhPho(DThanhPho tp)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            ThanhPho tpho = new ThanhPho();
            tpho.MaThanhPho = tp.MaThanhPho;
            tpho.TenThanhPho = tp.TenThanhPho;
            return tpho;

        }
        public void ThemThanhPho(DThanhPho tp)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            db.ThanhPhos.Add(ChuyenDoiThanhPho(tp));
            db.SaveChanges();
        }
        public void XoaThanhPho(string Matp)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            db.ThanhPhos.Remove(LayThanhPho(Matp));
            db.SaveChanges();
        }
        public void CapNhatThanhPho(ThanhPho tp)
        {
            QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();
            var x = from p in db.ThanhPhos
                    where p.MaThanhPho.Equals(tp.MaThanhPho)
                    select p;
            var khachHangUpdate = x.First();
            khachHangUpdate = tp;
            db.SaveChanges();
        }
    }
}

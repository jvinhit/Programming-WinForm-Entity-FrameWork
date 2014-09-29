using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace DataAccessLayer
{

    public class QuanLyBanHangDataContext: DbContext
    {
        /// <summary>
        /// Tạo csdl với các lớp vừa dn ở trên
        /// </summary>
        public QuanLyBanHangDataContext() :
            base("QuanLyBanHangDataContext")
        {

        }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ThanhPho> ThanhPhos { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        /// <summary>
        /// tạo 2 khóa chính cho ChiTietHoaDon
        /// Cái này do bag Chi Tiet Hoa Don Lay DL tu 2 bang khac ma ko dn lai dl 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<ChiTietHoaDon>().HasKey(s => new { s.MaHD, s.MaSP });
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<QuanLyBanHangDataContext>());
            /*Database.SetInitializer(new DropCreateDatabaseIfModelChanges<QLBHContext>());*/
        }
    }
}

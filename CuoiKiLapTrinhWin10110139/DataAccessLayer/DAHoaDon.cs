using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class HoaDon
    {
        [Key]
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayLapHD { get; set; }
        public DateTime NgayNhanHang { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        [ForeignKey("MaKH")]
        public KhachHang KhachHang { get; set; }
        [ForeignKey("MaNV")]
        public NhanVien NhanVien { get; set; }
    }
}

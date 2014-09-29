using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class SanPham
    {
        [Key]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonViTinh { get; set; }
        public string DonGia { get; set; }
        public Byte[] Hinh { get; set; }
        public string MaLoaiSP { get; set; }
        public Byte[] Hinh2 { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        [ForeignKey("MaLoaiSP")]
        public LoaiSanPham LoaiSanPham { get; set; }
    }
}

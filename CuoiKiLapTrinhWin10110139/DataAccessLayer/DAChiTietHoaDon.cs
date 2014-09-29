using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class ChiTietHoaDon
    {
        [Key, Column(Order = 1)]
        public string MaHD { get; set; }
        [Key, Column(Order = 2)]
        public string MaSP { get; set; }
        public string SoLuong { get; set; }
        [ForeignKey("MaHD")]
        public HoaDon HoaDon { get; set; }
        [ForeignKey("MaSP")]
        public SanPham SanPham { get; set; }
    }
}

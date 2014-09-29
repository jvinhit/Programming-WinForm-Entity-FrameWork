using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace DataAccessLayer
{
    public class LoaiSanPham
    {
        [Key]
        public string MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }
        public ICollection<SanPham> SanPhams { get; set; }
    }
}

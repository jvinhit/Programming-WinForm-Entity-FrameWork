using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace DataAccessLayer
{
    public class NhanVien
    {
        [Key]
        public string MaNV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public Boolean Nu { get; set; }
        public DateTime NgayNV { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public Byte[] Hinh { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}

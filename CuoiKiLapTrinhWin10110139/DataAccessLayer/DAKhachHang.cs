using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace DataAccessLayer
{
    public class KhachHang
    {
        [Key]
        public string MaKH { get; set; }
        public string TenCty { get; set; }
        public string DiaChi { get; set; }
        public string MaThanhPho { get; set; }
        public string DienThoai { get; set; }
       
        /// <summary>
        /// Tạo relation giữa HOa Don Va Khach Hang
        /// </summary>
        public ICollection<HoaDon> HoaDons { get; set; }
        /// <summary>
        /// Tham chiếu đến bảng Thành Phố
        /// 
        /// </summary>
        [ForeignKey("MaThanhPho")]
        public ThanhPho ThanhPho { get; set; }
    }
}

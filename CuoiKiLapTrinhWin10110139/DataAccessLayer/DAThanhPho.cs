using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class ThanhPho
    {
        [Key]
        public string MaThanhPho { get; set; }
        public string TenThanhPho { get; set; }
        public ICollection<KhachHang> KhachHangs { get; set; }
    }
}

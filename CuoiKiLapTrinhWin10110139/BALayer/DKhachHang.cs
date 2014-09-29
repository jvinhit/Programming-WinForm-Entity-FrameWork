using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BALayer
{
    public class DKhachHang
    {
        private string maKH;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string tenCty;
        public string TenCty
        {
            get { return tenCty; }
            set { tenCty = value; }
        }
        private string diachi;
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private string mathanhpho;
        public string MaThanhPho
        {
            get { return mathanhpho; }
            set { mathanhpho = value; }
        }
        private string dienthoai;
        public string DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
      
     

        public DKhachHang()
        {
        }
        /// <summary>
        /// Tham chieu lay khach hang
        /// </summary>
        public DKhachHang(KhachHang kh)
        {
            MaKH = kh.MaKH;
            TenCty = kh.TenCty;
            DiaChi = kh.DiaChi;
            DienThoai = kh.DienThoai;
            MaThanhPho = kh.MaThanhPho;
         
        }

    }
}

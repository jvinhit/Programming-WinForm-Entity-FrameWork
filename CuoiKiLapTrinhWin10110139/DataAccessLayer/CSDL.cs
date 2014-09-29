using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class Data
    {
        public void ThemDuLieu()
        {

            var DB = new QuanLyBanHangDataContext();

            #region ThanhPho
            var tp1 = new ThanhPho { MaThanhPho = "01", TenThanhPho = "Tay Ninh" };
            var tp2 = new ThanhPho { MaThanhPho = "02", TenThanhPho = "TP. Huế" };
            var tp3 = new ThanhPho { MaThanhPho = "03", TenThanhPho = "TP. Hồ Chí Minh" };
            var tp4 = new ThanhPho { MaThanhPho = "04", TenThanhPho = "TP.Nha Trang" };
            var tp5 = new ThanhPho { MaThanhPho = "05", TenThanhPho = "Vũng Tàu" };
            var tp6 = new ThanhPho { MaThanhPho = "06", TenThanhPho = "Hải Phòng" };
            var tp7 = new ThanhPho { MaThanhPho = "07", TenThanhPho = "Đà Lạt" };
            var tp8 = new ThanhPho { MaThanhPho = "08", TenThanhPho = "Đà Nẵng" };
            #endregion

            #region KhachHang


            var kh1 = new KhachHang { MaKH = "AGROMAS", TenCty = "Cơ Điện Nông Nghiệp Q.3", DiaChi = "311 Hai Bà Trưng P.8 Q.3",ThanhPho=tp3, DienThoai = "0982919831"};
            var kh2 = new KhachHang { MaKH = "ALIBABA", TenCty = "Cty Phần mềm Kế toán ALIBABA", DiaChi = "01 Võ Văn Ngân TD", ThanhPho= tp5, DienThoai = "0909999999" };
            var kh3 = new KhachHang { MaKH = "APTECHBK", TenCty = "NBách Khoa Aptech 2", DiaChi = "NBách Khoa Aptech 2", ThanhPho = tp3, DienThoai = "088234567" };
            var kh4 = new KhachHang { MaKH = "ATCADA", TenCty = "Thiết kế ADA", DiaChi = "11 Giảng Võ", ThanhPho=tp1, DienThoai = "0434423222" };
            var kh5 = new KhachHang { MaKH = "BABAGOS", TenCty = "Du lịch Bai Dua", DiaChi = "86 Hạ Long",ThanhPho=tp2, DienThoai = "0123234567" };
            var kh6 = new KhachHang { MaKH = "CATASA", TenCty = "Cát Tiên Graphics Design", DiaChi = "123 Tràng Tiền",ThanhPho=tp3 , DienThoai = "2354625256" };
            var kh7 = new KhachHang { MaKH = "CINOTEC", TenCty = "Điện toán CINOTEC", DiaChi = "91 Lê Duẩn", ThanhPho=tp6, DienThoai = "2562562562"};
            var kh8 = new KhachHang { MaKH = "DOSOVIP", TenCty = "Cơ Khí Đông Sơn", DiaChi = "123 Trần Phú", ThanhPho=tp7, DienThoai = "3456789012"};
            var kh9 = new KhachHang { MaKH = "PMDANA", TenCty = "Phần mềm Đa Năng", DiaChi = "12 Đinh Tiên Hoàng", ThanhPho=tp4, DienThoai = "0580302010"};

            #endregion

            #region NhanVien

            var nv1 = new NhanVien { MaNV = "nv0001", Ho = "Nguyễn Thi", Ten = "Văn", Nu = false, NgayNV = new DateTime(2010, 01, 01), DiaChi = "01 Võ Văn Ngân", DienThoai = "0198765233", Hinh = null };
            var nv2 = new NhanVien { MaNV = "nv0002", Ho = "Lê", Ten = "Thu", Nu = true, NgayNV = new DateTime(2010, 01, 08), DiaChi = "02 Hùng Vương", DienThoai = "0123456774", Hinh = null };
            var nv3 = new NhanVien { MaNV = "nv0003", Ho = "Nguyễn", Ten = "Anh", Nu = true, NgayNV = new DateTime(2009, 05, 06), DiaChi = "BK Aptech", DienThoai = "088345567", Hinh = null };
            var nv4 = new NhanVien { MaNV = "nv0004", Ho = "Trần", Ten = "Lan", Nu = true, NgayNV = new DateTime(2009, 09, 09), DiaChi = "23 Bạch Đằng", DienThoai = "0903999111", Hinh = null };
            var nv5 = new NhanVien { MaNV = "nv0005", Ho = "Trần", Ten = "Lan", Nu = true, NgayNV = new DateTime(2009, 09, 09), DiaChi = "23 Bạch Đằng", DienThoai = "0903999111", Hinh = null };
            var nv6 = new NhanVien { MaNV = "nv0006", Ho = "Nguyễn", Ten = "Đạo", Nu = false, NgayNV = new DateTime(1989, 11, 01), DiaChi = "36 Bình Giã", DienThoai = "0903982082", Hinh = null };
            var nv7 = new NhanVien { MaNV = "nv0007", Ho = "Lê", Ten = "Nam", Nu = false, NgayNV = new DateTime(2010, 11, 01), DiaChi = "Nhất Nghệ", DienThoai = "356724572", Hinh = null };
            #endregion

            #region HoaDon
            var hd1 = new HoaDon { MaHD = "10141", KhachHang = kh3, NhanVien = nv6, NgayLapHD = new DateTime(2010, 03, 05), NgayNhanHang = new DateTime(2013, 02, 03) };
            var hd2 = new HoaDon { MaHD = "10145", KhachHang = kh1, NhanVien = nv1, NgayLapHD = new DateTime(2010, 01, 01), NgayNhanHang = new DateTime(2010, 02, 01) };
            var hd3 = new HoaDon { MaHD = "10148", KhachHang = kh6, NhanVien = nv2, NgayLapHD = new DateTime(2009, 01, 01), NgayNhanHang = new DateTime(2009, 02, 02) };
            var hd4 = new HoaDon { MaHD = "10150", KhachHang = kh7, NhanVien = nv6, NgayLapHD = new DateTime(2010, 01, 05), NgayNhanHang = new DateTime(2010, 02, 01) };
            var hd5 = new HoaDon { MaHD = "10151", KhachHang = kh3, NhanVien = nv6, NgayLapHD = new DateTime(2010, 10, 03), NgayNhanHang = new DateTime(2010, 10, 03) };
            var hd6 = new HoaDon { MaHD = "10152", KhachHang = kh1, NhanVien = nv1, NgayLapHD = new DateTime(2010, 11, 25), NgayNhanHang = new DateTime(2010, 11, 25) };
            var hd7 = new HoaDon { MaHD = "10153", KhachHang = kh2, NhanVien = nv1, NgayLapHD = new DateTime(2010, 11, 27), NgayNhanHang = new DateTime(2010, 11, 27) };
            #endregion

            #region LoaiSanPham


            var lsp1 = new LoaiSanPham { MaLoaiSP = "L1", TenLoaiSP = "Máy tính" };
            var lsp2 = new LoaiSanPham { MaLoaiSP = "L2", TenLoaiSP = "Máy In" };
            #endregion

            #region SanPham

            var sp1 = new SanPham { MaSP = "1", TenSP = "Laptop Toshiba", DonViTinh = "Cái", DonGia = "30000", Hinh = null, LoaiSanPham = lsp1, Hinh2 = null };
            var sp2 = new SanPham { MaSP = "2", TenSP = "Cà phê", DonViTinh = "Bịch", DonGia = "20000", Hinh = null, LoaiSanPham = lsp2, Hinh2 = null };
            var sp3 = new SanPham { MaSP = "3", TenSP = "Bánh kem", DonViTinh = "Thùng", DonGia = "20000", Hinh = null, LoaiSanPham = lsp2, Hinh2 = null };
            var sp4 = new SanPham { MaSP = "4", TenSP = "Bơ", DonViTinh = "kg", DonGia = "50000", Hinh = null, LoaiSanPham = lsp2, Hinh2 = null };
            var sp5 = new SanPham { MaSP = "5", TenSP = "Bánh mì", DonViTinh = "Cái", DonGia = "10000", Hinh = null, LoaiSanPham = lsp1, Hinh2 = null };
            var sp6 = new SanPham { MaSP = "6", TenSP = "Máy In", DonViTinh = "Thùng", DonGia = "2000000", Hinh = null, LoaiSanPham = lsp2, Hinh2 = null };
            var sp7 = new SanPham { MaSP = "7", TenSP = "Táo", DonViTinh = "kg", DonGia = "4500", Hinh = null, LoaiSanPham = lsp1, Hinh2 = null };
            var sp8 = new SanPham { MaSP = "8", TenSP = "Cá hộp", DonViTinh = "Thùng", DonGia = "500000", Hinh = null, LoaiSanPham = lsp1, Hinh2 = null };
            var sp9 = new SanPham { MaSP = "9", TenSP = "Desktop", DonViTinh = "Cái", DonGia = "3000000", Hinh = null, LoaiSanPham = lsp2, Hinh2 = null };
            var sp10 = new SanPham { MaSP = "10", TenSP = "Muc", DonViTinh = "Kg", DonGia = "250000", Hinh = null, LoaiSanPham = lsp1, Hinh2 = null };
            var sp11 = new SanPham { MaSP = "11", TenSP = "Sau rieng cai mon", DonViTinh = "kg", DonGia = "45000", Hinh = null, LoaiSanPham = lsp1, Hinh2 = null };
            #endregion

            #region Du lieu bang chi tiet ho don
            var cthd1 = new ChiTietHoaDon { HoaDon = hd1, SanPham = sp3, SoLuong = "232" };
            var cthd2 = new ChiTietHoaDon { HoaDon = hd2, SanPham = sp1, SoLuong = "40" };
            var cthd3 = new ChiTietHoaDon { HoaDon = hd2, SanPham = sp2, SoLuong = "35" };
            var cthd4 = new ChiTietHoaDon { HoaDon = hd2, SanPham = sp4, SoLuong = "25" };
            var cthd5 = new ChiTietHoaDon { HoaDon = hd3, SanPham = sp3, SoLuong = "25" };
            var cthd6 = new ChiTietHoaDon { HoaDon = hd3, SanPham = sp4, SoLuong = "26" };
            var cthd7 = new ChiTietHoaDon { HoaDon = hd4, SanPham = sp1, SoLuong = "35" };
            var cthd8 = new ChiTietHoaDon { HoaDon = hd4, SanPham = sp4, SoLuong = "45" };
            #endregion

            #region Them du lieu bang thanh pho

            var tp01 = DB.ThanhPhos.Find("01");
            if (tp01 == null)
            {
                DB.ThanhPhos.Add(tp1);
            }
            var tp02 = DB.ThanhPhos.Find("02");
            if (tp02 == null)
            {
                DB.ThanhPhos.Add(tp2);
            }
            var tp03 = DB.ThanhPhos.Find("03");
            if (tp03 == null)
            {
                DB.ThanhPhos.Add(tp3);
            }
            var tp04 = DB.ThanhPhos.Find("04");
            if (tp04 == null)
            {
                DB.ThanhPhos.Add(tp4);
            }
            var tp05 = DB.ThanhPhos.Find("05");
            if (tp05 == null)
            {
                DB.ThanhPhos.Add(tp5);
            }
            var tp06 = DB.ThanhPhos.Find("06");
            if (tp06 == null)
            {
                DB.ThanhPhos.Add(tp6);
            }
            var tp07 = DB.ThanhPhos.Find("07");
            if (tp07 == null)
            {
                DB.ThanhPhos.Add(tp7);
            }
            var tp08 = DB.ThanhPhos.Find("08");
            if (tp08 == null)
            {
                DB.ThanhPhos.Add(tp8);
            }

            #endregion

            #region Them du lieu bang khach hang

            var kh01 = DB.KhachHangs.Find("AGROMAS");
            if (kh01 == null)
            {
                DB.KhachHangs.Add(kh1);
            }
            var kh02 = DB.KhachHangs.Find("ALIBABA");
            if (kh02 == null)
            {
                DB.KhachHangs.Add(kh2);
            }
            var kh03 = DB.KhachHangs.Find("APTECHBK");
            if (kh03 == null)
            {
                DB.KhachHangs.Add(kh3);
            }
            var kh04 = DB.KhachHangs.Find("ATCADA");
            if (kh04 == null)
            {
                DB.KhachHangs.Add(kh4);
            }
            var kh05 = DB.KhachHangs.Find("BABAGOS");
            if (kh05 == null)
            {
                DB.KhachHangs.Add(kh5);
            }
            var kh06 = DB.KhachHangs.Find("CATASA");
            if (kh06 == null)
            {
                DB.KhachHangs.Add(kh6);
            }
            var kh07 = DB.KhachHangs.Find("CINOTEC");
            if (kh07 == null)
            {
                DB.KhachHangs.Add(kh7);
            }
            var kh08 = DB.KhachHangs.Find("DOSOVIP");
            if (kh08 == null)
            {
                DB.KhachHangs.Add(kh8);
            }
            var kh09 = DB.KhachHangs.Find("PMDANA");
            if (kh09 == null)
            {
                DB.KhachHangs.Add(kh9);
            }

            #endregion

            #region Them du lieu bang nhan vien


            var nv01 = DB.NhanViens.Find("nv0001");
            if (nv01 == null)
            {
                DB.NhanViens.Add(nv1);
            }
            var nv02 = DB.NhanViens.Find("nv0002");
            if (nv02 == null)
            {
                DB.NhanViens.Add(nv2);
            }
            var nv03 = DB.NhanViens.Find("nv0003");
            if (nv03 == null)
            {
                DB.NhanViens.Add(nv3);
            }
            var nv04 = DB.NhanViens.Find("nv0004");
            if (nv04 == null)
            {
                DB.NhanViens.Add(nv4);
            }
            var nv05 = DB.NhanViens.Find("nv0005");
            if (nv05 == null)
            {
                DB.NhanViens.Add(nv5);
            }
            var nv06 = DB.NhanViens.Find("nv0006");
            if (nv06 == null)
            {
                DB.NhanViens.Add(nv6);
            }
            var nv07 = DB.NhanViens.Find("nv0007");
            if (nv07 == null)
            {
                DB.NhanViens.Add(nv7);
            }

            #endregion

            #region Them du lieu bang hoa don

            var hd01 = DB.HoaDons.Find("10141");
            if (hd01 == null)
            {
                DB.HoaDons.Add(hd1);
            }
            var hd02 = DB.HoaDons.Find("10145");
            if (hd02 == null)
            {
                DB.HoaDons.Add(hd2);
            }
            var hd03 = DB.HoaDons.Find("10148");
            if (hd03 == null)
            {
                DB.HoaDons.Add(hd3);
            }
            var hd04 = DB.HoaDons.Find("10150");
            if (hd04 == null)
            {
                DB.HoaDons.Add(hd4);
            }
            var hd05 = DB.HoaDons.Find("10151");
            if (hd05 == null)
            {
                DB.HoaDons.Add(hd5);
            }
            var hd06 = DB.HoaDons.Find("10152");
            if (hd06 == null)
            {
                DB.HoaDons.Add(hd6);
            }
            var hd07 = DB.HoaDons.Find("10153");
            if (hd07 == null)
            {
                DB.HoaDons.Add(hd7);
            }

            #endregion

            #region Them du lieu cho bang loai san pham
            var lsp01 = DB.LoaiSanPhams.Find("L1");

            if (lsp01 == null)
            {
                DB.LoaiSanPhams.Add(lsp1);
            }
            var lsp02 = DB.LoaiSanPhams.Find("L2");
            if (lsp02 == null)
            {
                DB.LoaiSanPhams.Add(lsp2);
            }
            #endregion

            #region Them du lieu bang san pham


            var sp01 = DB.SanPhams.Find("1");
            if (sp01 == null)
            {
                DB.SanPhams.Add(sp1);
            }
            var sp02 = DB.SanPhams.Find("2");
            if (sp02 == null)
            {
                DB.SanPhams.Add(sp2);
            }
            var sp03 = DB.SanPhams.Find("3");
            if (sp03 == null)
            {
                DB.SanPhams.Add(sp3);
            }
            var sp04 = DB.SanPhams.Find("4");
            if (sp04 == null)
            {
                DB.SanPhams.Add(sp4);
            }
            var sp05 = DB.SanPhams.Find("5");
            if (sp05 == null)
            {
                DB.SanPhams.Add(sp5);
            }
            var sp06 = DB.SanPhams.Find("6");
            if (sp06 == null)
            {
                DB.SanPhams.Add(sp6);
            }
            var sp07 = DB.SanPhams.Find("7");
            if (sp07 == null)
            {
                DB.SanPhams.Add(sp7);
            }
            var sp08 = DB.SanPhams.Find("8");
            if (sp08 == null)
            {
                DB.SanPhams.Add(sp8);
            }
            var sp09 = DB.SanPhams.Find("9");
            if (sp09 == null)
            {
                DB.SanPhams.Add(sp9);
            }
            var sp010 = DB.SanPhams.Find("10");
            if (sp010 == null)
            {
                DB.SanPhams.Add(sp10);
            }
            var sp011 = DB.SanPhams.Find("11");
            if (sp011 == null)
            {
                DB.SanPhams.Add(sp11);
            }

            #endregion

            #region Them du lieu bang chi tiet hoa don

            var ct1 = DB.ChiTietHoaDons.Find("10141", "3");
            if (ct1 == null)
            {
                DB.ChiTietHoaDons.Add(cthd1);
            }
            var ct2 = DB.ChiTietHoaDons.Find("10145", "1");
            if (ct2 == null)
            {
                DB.ChiTietHoaDons.Add(cthd2);
            }
            var ct3 = DB.ChiTietHoaDons.Find("10145", "2");
            if (ct3 == null)
            {
                DB.ChiTietHoaDons.Add(cthd3);
            }
            var ct4 = DB.ChiTietHoaDons.Find("10145", "4");
            if (ct4 == null)
            {
                DB.ChiTietHoaDons.Add(cthd4);
            }
            var ct5 = DB.ChiTietHoaDons.Find("10148", "3");
            if (ct5 == null)
            {
                DB.ChiTietHoaDons.Add(cthd5);
            }
            var ct6 = DB.ChiTietHoaDons.Find("10148", "4");
            if (ct6 == null)
            {
                DB.ChiTietHoaDons.Add(cthd6);
            }
            var ct7 = DB.ChiTietHoaDons.Find("10150", "1");
            if (ct7 == null)
            {
                DB.ChiTietHoaDons.Add(cthd7);
            }
            var ct8 = DB.ChiTietHoaDons.Find("10150", "4");
            if (ct8 == null)
            {
                DB.ChiTietHoaDons.Add(cthd8);
            }

            #endregion

            //Get Validation
            bool error = false;
            var validationErrors = DB.GetValidationErrors()
                .Where(vr => !vr.IsValid)
                .SelectMany(vr => vr.ValidationErrors);

            foreach (var err in validationErrors)
            {
                Console.WriteLine(err.ErrorMessage);
                error = true;
            }

            if (!error)
            {
                DB.SaveChanges();
            }
        }
    }
}

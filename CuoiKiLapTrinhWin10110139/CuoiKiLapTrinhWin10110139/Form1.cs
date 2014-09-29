using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using BALayer;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DataAccessLayer;

namespace CuoiKiLapTrinhWin10110139
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
        
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbSkins, true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData load = new LoadData();
            load.InitialData();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            //DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle("Valentine");

        }
        BAThanhPho thanhpho = new BAThanhPho(); 
        public void LoadDuLieuThanhPho()
        {
            gridControl1.RefreshDataSource();
            gridView1.RefreshData();
            gridControl1.DataSource = thanhpho.XemDanhMucThanhPho();
            gridView1.PopulateColumns();

        }
        private void ribbonControl1_ShowCustomizationMenu(object sender, DevExpress.XtraBars.Ribbon.RibbonCustomizationMenuEventArgs e)
        {
            /*ribbonControl1.ShowCustomizationMenu*/
        }
        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new frmDangNhap();
            frm.Text = "Đăng nhập quản lý hệ thống!";
            frm.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new frmConnectDB();
            frm.Text = "Connect to SQL Server with Form";
            frm.ShowDialog();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadDuLieuThanhPho();
        }
       BAKhachHang khachhang = new BAKhachHang();
        public void LoadDuLieuKhachHang()
        {
            gridControl1.DataSource = khachhang.XemDanhMucKhachHang();
            gridView1.PopulateColumns();
        }

        private void barbtnXemDanhMucKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadDuLieuKhachHang();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore;
//using web2.Areas.Admin.Models;
using web2.Models;

namespace web2.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }
        //public DbSet<AdminMenu> AdminMenus { get; set; }
        public DbSet<BaiViet> BaiViets { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<LienHe> LienHes { get; set; }
        public DbSet<View_GioHang_SanPham> view_GioHang_SanPhams { get; set; }
    }
}

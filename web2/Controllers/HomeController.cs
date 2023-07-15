using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web2.Models;
using web2.Utilities;

namespace web2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CuaHang()
        {
            var sp = _context.SanPhams.ToList();
            return View(sp);
        }
        public IActionResult ChiTietSanPham(int id)
        {
            var ctsp = _context.SanPhams.Find(id);
            return View(ctsp);
        }

        public IActionResult ThemSanPhamVaoGioHang(int SoLuong, int IDSanPhamNguoiDungDatHang)
        {
            int IDNguoiDungDangNhap = Functions._UserID;
            var spNguoiDungDatTrongGioHang = _context.GioHangs.Where(db => db.IDNguoiDung == IDNguoiDungDangNhap
            && db.IDSanPham == IDSanPhamNguoiDungDatHang).FirstOrDefault();
            if (spNguoiDungDatTrongGioHang == null) // trường hợp người dùng chưa thêm sp vào giỏ hàng
            {
                var spNguoiDungDatTrongGioHangMoi = new GioHang(); //khởi tạo các thuộc tính trong giỏ hàng với giá trị rỗng
                spNguoiDungDatTrongGioHangMoi.SoLuong = SoLuong;
                spNguoiDungDatTrongGioHangMoi.IDSanPham = IDSanPhamNguoiDungDatHang;
                spNguoiDungDatTrongGioHangMoi.IDNguoiDung = IDNguoiDungDangNhap;

                _context.GioHangs.Add(spNguoiDungDatTrongGioHangMoi);
                _context.SaveChanges();

            }
            else
            {
                spNguoiDungDatTrongGioHang.SoLuong = spNguoiDungDatTrongGioHang.SoLuong + SoLuong;
                _context.GioHangs.Update(spNguoiDungDatTrongGioHang);
                _context.SaveChanges();

            }
            return RedirectToAction("GioHang");
        }

        public IActionResult GioHang()
        {
            var gh = _context.view_GioHang_SanPhams.Where(db => db.IDNguoiDung == Functions._UserID).ToList();
            return View(gh);
        }


        public IActionResult DSBaiViet()
        {
            var bv = _context.BaiViets.Take(3).ToList();
            return View(bv);
        }
        public IActionResult BaiVietChiTiet(int id)
        {
            var ctbv = _context.BaiViets.Find(id);
            return View(ctbv);
        }
        public IActionResult LienHe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult XLLienHe(LienHe lh)
        {
            lh.NgayTao = DateTime.Now;
            _context.LienHes.Add(lh);
            _context.SaveChanges();
            TempData["msg"] = "Gửi thành công";
            return RedirectToAction("LienHe");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
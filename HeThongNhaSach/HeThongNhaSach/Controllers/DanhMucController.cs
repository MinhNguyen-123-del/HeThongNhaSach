using Microsoft.AspNetCore.Mvc;
using HeThongNhaSach.Models; // nhớ import namespace chứa DbContext và Model
using System.Linq;

namespace HeThongNhaSach.Controllers
{
    public class DanhMucController : Controller
    {
        private readonly NhaSachContext _context;

        // Constructor để inject DbContext
        public DanhMucController(NhaSachContext context)
        {
            _context = context;
        }

        public IActionResult DanhMuc()
        {
            return View();
        }

        // Trang chi tiết từng danh mục
        public IActionResult SachTrongNuoc()
        {
            var sanPhams = _context.SanPhams
                                   .Where(sp => sp.MaDm == 1)
                                   .ToList();

            return View(sanPhams);   // ✅ phải truyền List<SanPham>
        }


        public IActionResult SachNgoaiNuoc()
        {
            var sanPhams = _context.SanPhams
                                   .Where(sp => sp.MaDm == 2) // nhớ: MaDm, không phải MaDM
                                   .ToList();
            return View(sanPhams);  // ✅ phải truyền model vào
        }


        public IActionResult DungCuHocSinh()
        {
            var sanPhams = _context.SanPhams
                                   .Where(sp => sp.MaDm == 3) // nhớ: MaDm, không phải MaDM
                                   .ToList();
            return View(sanPhams);  // ✅ phải truyền model vào
        }

        public IActionResult DoChoiTreEm()
        {
            var sanPhams = _context.SanPhams
                                   .Where(sp => sp.MaDm == 4) // nhớ: MaDm, không phải MaDM
                                   .ToList();
            return View(sanPhams);  // ✅ phải truyền model vào
        }
    }
}

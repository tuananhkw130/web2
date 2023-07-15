using Microsoft.AspNetCore.Mvc;
using web2.Models;

namespace web2.Components
{
    [ViewComponent(Name = "DanhMucSanPham")]
    public class DanhMucSanPhamComponent : ViewComponent
    {
        private DataContext _context;

        public DanhMucSanPhamComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dm=_context.DanhMucs.ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", dm));
        }
    }
}

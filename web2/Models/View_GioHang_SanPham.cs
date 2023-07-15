using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web2.Models
{

    [Table("View_GioHang_SanPham")]
    public class View_GioHang_SanPham
    {
        [Key]
        public int ID { get; set; }
        public string? TenSanPham { get; set; }
        public string? Anh { get; set; }
        public int? SoLuong { get; set; }
        public long Gia { get; set; }
        public int IDNguoiDung { get; set; }
    }

}
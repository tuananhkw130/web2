using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web2.Models
{

    [Table("GioHang")]
    public class GioHang
    {
        [Key]
        public int ID { get; set; }
        public int IDSanPham { get; set; }
        public int? SoLuong { get; set; }
     
        public int IDNguoiDung { get; set; }
    }

}
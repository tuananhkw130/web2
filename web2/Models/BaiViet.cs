using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web2.Models
{

    [Table("BaiViet")]
    public class BaiViet
    {
        [Key]
        public int ID { get; set; }
        public string? TieuDe { get; set; }
        public string? NoiDung { get; set; }
        public string? Anh { get; set; }
        public DateTime NgayTao { get; set; }
        public int IDNguoiTao { get; set; }
        public bool? TrangThai { get; set; }
    }

}
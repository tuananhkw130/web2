using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web2.Models
{

    [Table("DanhMuc")]
    public class DanhMuc
    {
        [Key]
        public int ID { get; set; }
        public string? TenDanhMuc { get; set; }
        public string? AnhMinhHoa { get; set; }
    }

}
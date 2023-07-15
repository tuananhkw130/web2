using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web2.Models
{

    [Table("LienHe")]
    public class LienHe
    {
        [Key]
        public int ID { get; set; }
        public string? Ten { get; set; }
        public string? Email { get; set; }
        public string? TieuDe { get; set; }
        public string? NoiDung { get; set; }
        public DateTime NgayTao { get; set; }
        
      
    }

}
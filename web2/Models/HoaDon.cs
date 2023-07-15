﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web2.Models
{

    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public int ID { get; set; }
        public int IDNguoiDung { get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayDat { get; set; }
        public string TinNhan { get; set; }
        public string DiaChi { get; set; }
        public string TenNguoiNhan { get; set; }
        public int TongSoTien { get; set; }
    }

}
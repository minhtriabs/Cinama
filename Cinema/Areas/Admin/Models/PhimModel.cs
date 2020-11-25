using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class PhimModel
    {
        [Key]
        public int IDPhim { get; set; }
        public int IDPhong { get; set; }
        [StringLength(100)]
        public string AnhPhim { get; set; }
        [StringLength(50)]
        public string TenPhim { get; set; }
        [StringLength(100)]
        public string TenDienVien { get; set; }
        [StringLength(100)]
        public string TenNgonNgu { get; set; }
        [StringLength(100)]
        public string TheLoai { get; set; }
        [StringLength(100)]
        public string TenPhuDe { get; set; }
        [StringLength(50)]
        public string DaoDien { get; set; }
        [Display(Name = "KhoiChieu"), DataType(DataType.Date)]
        public DateTime KhoiChieu { get; set; }
        public int ThoiLuong { get; set; }
        public int Rated { get; set; }
        public int TrangThai { get; set; }
        [ForeignKey("IDPhong")]
        public virtual PhongModel idphong { get; set; }

    }
}

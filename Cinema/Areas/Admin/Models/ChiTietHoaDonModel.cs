using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class ChiTietHoaDonModel
    {
        [Key]
        public int IDCTHD { get; set; }
        public int IDHD { get; set; }
        [StringLength(50)]
        public string TenRap { get; set; }
        [StringLength(50)]
        public string TenPhim { get; set; }
        [Display(Name = "NgayThang"), DataType(DataType.Time)]
        public DateTime GioChieu { get; set; }
        [Display(Name = "NgayThang"), DataType(DataType.Date)]
        public DateTime NgayChieu { get; set; }
        [StringLength(50)]
        public string PhongChieu { get; set; }
        [StringLength(50)]
        public string TenGhe { get; set; }
        public int SoLuong { get; set; }
        [Range(1000, 1000000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal GiaLG { get; set; }
        [ForeignKey("IDHD")]
        public virtual HoaDonModel idhd { get; set; }
    }
}

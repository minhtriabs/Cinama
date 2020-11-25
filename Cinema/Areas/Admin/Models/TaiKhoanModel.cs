using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class TaiKhoanModel
    {
        [Key]
        public int IDTK { get; set; }
        public int IDLTK { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }
        [StringLength(50)]
        public string Ho { get; set; }
        [StringLength(5)]
        public string GioiTinh { get; set; }
        [MaxLength(10)]
        public string DienThoai { get; set; }

        [Display(Name = "NgaySinh"), DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(250)]
        public string DiaChi { get; set; }
        [StringLength(100)]
        public string AnhDaiDien { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int TrangThai { get; set; }
        [ForeignKey("IDLTK")]
        public virtual LoaiTKModel idltk { get; set; }
    }
}

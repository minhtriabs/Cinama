using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class KhungGioModel
    {
        [Key]
        public int IDKG { get; set; }
        public int IDPhim { get; set; }
        [Display(Name = "ThoiGian"), DataType(DataType.Time)]
        public DateTime ThoiGian { get; set; }
        public int TrangThai { get; set; }
        [ForeignKey("IDPhim")]
        public virtual PhimModel idphim { get; set; }
    }
}

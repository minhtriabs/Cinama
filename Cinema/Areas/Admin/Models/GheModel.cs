using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class GheModel
    {
        [Key]
        public int IDGhe { get; set; }
        public int IDLG { get; set; }
        public int IDPhong { get; set; }
        [StringLength(50)]
        public string TenGhe { get; set; }
        public int SoGhe { get; set; }
        public int TrangThai { get; set; }
        [ForeignKey("IDPhong")]
        public virtual PhongModel idphong { get; set; }
        [ForeignKey("IDLG")]
        public virtual LoaiGheModel idlg { get; set; }
    }
}

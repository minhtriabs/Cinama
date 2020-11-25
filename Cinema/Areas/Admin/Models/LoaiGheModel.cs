using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class LoaiGheModel
    {
        [Key]
        public int IDLG { get; set; }
        [StringLength(50)]
        public string TenLoai { get; set; }
        [Range(1000, 1000000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal GiaLG { get; set; }
        public int TrangThai { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class HoaDonModel
    {
        [Key]
        public int IDHD { get; set; }
        public int IDTK { get; set; }
        public int IDRap { get; set; }
        [Range(1000, 1000000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal ThanhTien { get; set; }
        [ForeignKey("IDTK")]
        public virtual TaiKhoanModel idtk { get; set; }
        [ForeignKey("IDRap")]
        public virtual RapModel idrap { get; set; }
    }
}

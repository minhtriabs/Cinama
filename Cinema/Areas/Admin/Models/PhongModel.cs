using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class PhongModel
    {
        [Key]
        public int IDPhong { get; set; }
        public int SoPhong { get; set; }
        public int TrangThai { get; set; }

        public int IDRap { get; set; }
        [ForeignKey("IDRap")]
        public virtual RapModel idrap { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class LoaiTKModel
    {
        [Key]
        public int IDLTK { get; set; }
        [StringLength(50)]
        public string TenLTK { get; set; }
        public int TrangThai { get; set; }
    }
}

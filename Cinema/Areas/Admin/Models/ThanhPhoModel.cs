using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class ThanhPhoModel
    {
        [Key]
        public int IDTP { get; set; }
        [StringLength(50)]
        public string TenTP { get; set; }
        public int TrangThai { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Models
{
    public class RapModel
    {
        [Key]
        public int IDRap { get; set; }

        [StringLength(50)]
        public string TenRap { get; set; }
        public int TrangThai { get; set; }

        public int IDTP { get; set; }
        [ForeignKey("IDTP")]
        public virtual ThanhPhoModel idthanhpho { get; set; }

    }
}

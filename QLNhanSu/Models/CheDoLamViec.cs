using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class CheDoLamViec
    {
        [Key]
        [StringLength(10)]
        public string MaCheDo {  get; set; }
        [Required]
        [StringLength(10)]
        public string TimeLam1Day {  get; set; }
        [Required]
        [StringLength(10)]
        public string TimeLam1Week { get; set; }
    }
}

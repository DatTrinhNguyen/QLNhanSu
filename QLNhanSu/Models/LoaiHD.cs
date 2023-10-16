using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class LoaiHD
    {
        [Key]
        public int IDHD { get; set; }
        [Required]
        [StringLength(250)]
        public string TenHopDong {  get; set; }
        public HopDong HopDongLoaiHD { get; set; }
    }
}

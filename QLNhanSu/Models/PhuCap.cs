using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class PhuCap
    {
        [Key]
        [StringLength(10)]
        public string MaPhuCap {  get; set; }

        [Required][StringLength(250)]
        public string TenPhuCap { get; set; }

        [Required]
        public float MucPhuCap { get; set; }
        public CTBangLuong CTBangLuongPhuCap { get; set; }
        public CTHopDong CTHopDongPhuCap { get; set; }

    }
}

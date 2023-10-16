using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class CTHopDong
    {
        [Required][StringLength(10)]
        [ForeignKey(nameof(MaPhuCap))]
        public string MaPhuCap {  get; set; }
        public PhuCap CTHopDongPhuCap { get; set; }

        [Required][StringLength(10)]
        [ForeignKey(nameof(MaHD))]
        public string MaHD { get; set; }
        public HopDong CTHopDongHopDong { get; set; }
    }
}

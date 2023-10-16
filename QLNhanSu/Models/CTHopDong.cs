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
        [ForeignKey(nameof(PhuCap))]
        public string MaPhuCap {  get; set; }
        public CTHopDong CTHopDongPhuCap { get; set; }

        [Required][StringLength(10)]
        [ForeignKey(nameof(HopDong))]
        public string MaHD { get; set; }
        public CTHopDong CTHopDongHopDong { get; set; }
    }
}

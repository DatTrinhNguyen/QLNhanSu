using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class BangCong
    {
        [Key]
        [StringLength(10)]
        public string MaBangCong {  get; set; }

        [StringLength(10)]
        [ForeignKey(nameof(KyLuong))]
        public string MaKyLuong { get; set; }
        public KyLuong KyLuongBangCong { get; set; }

        [Required]
        public DateTime NgayLapBang { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class BaoHiemNhanVien
    {
        [Key]
        [StringLength(10)]
        public string MaBH {  get; set; }

        [Required]
        [ForeignKey(nameof(BaoHiem))]
        public int ID {  get; set; }
        public BaoHiemNhanVien BaoHiemNhanVienBaoHiem { get; set; }

        [Required]
        [StringLength (10)]
        [ForeignKey(nameof(HopDong))]
        public string MaHD {  get; set; }
        public BaoHiemNhanVien BaoHiemNhanVienHopDong { get; set; }

        [Required]
        public float MucDong {  get; set; }

        [Required]
        public DateTime NgayDong {  get; set; }
    }
}

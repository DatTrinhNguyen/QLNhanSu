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
        [ForeignKey(nameof(ID))]
        public int ID {  get; set; }
        public BaoHiem BaoHiemNhanVienBaoHiem { get; set; }

        [Required]
        [StringLength (10)]
        [ForeignKey(nameof(MaHD))]
        public string MaHD {  get; set; }
        public HopDong BaoHiemNhanVienHopDong { get; set; }

        [Required]
        public float MucDong {  get; set; }

        [Required]
        public DateTime NgayDong {  get; set; }
    }
}

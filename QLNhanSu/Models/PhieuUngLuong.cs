using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class PhieuUngLuong
    {
        [Key]
        [StringLength(10)]
        public string MaPhieuUng {  get; set; }

        [Required][StringLength(10)]
        [ForeignKey(nameof(MaNhanVien))]
        public string MaNhanVien {  get; set; }
        public NhanVien PhieuUngLuongNhanVien { get; set; }

        [Required]
        public float MucUngLuong {  get; set; }

        [Required]
        public DateTime NgayUng {  get; set; }
        public CTBangLuong CTBangLuongPhieuUngLuong { get; set; }

    }
}

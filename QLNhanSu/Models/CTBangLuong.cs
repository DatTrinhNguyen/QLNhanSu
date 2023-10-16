using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class CTBangLuong
    {
        [StringLength(10)]
        [ForeignKey(nameof(MaBangLuong))]
        public string MaBangLuong {  get; set; }
        public BangLuong CTBangLuongBangLuong {  set; get; }

        [Required]
        [StringLength(8)]
        [ForeignKey (nameof(MaKyLuong))]
        public string MaKyLuong { get; set; }
        public KyLuong CTBangLuongKyLuong { get; set; }

        [Required]
        [StringLength(10)]
        [ForeignKey(nameof(MaNhanVien))]
        public string MaNhanVien {  get; set; }
        public NhanVien CTBangLuongNhanVien { get; set; }
        
        [StringLength(10)]
        [ForeignKey(nameof(MaPhuCap))]
        public string MaPhuCap {  get; set; }
        public PhuCap CTBangLuongPhuCap { get; set; }

        [StringLength (10)]
        [ForeignKey(nameof(MaPhieuUng))]
        public string MaPhieuUng { get; set; }
        public PhieuUngLuong CTBangLuongPhieuUng { get; set;}

        public float LuongPhuTroi { get; set; }

        public float LuongCoBan { get; set; }

        public float TongLuong {  get; set; }



    }
}

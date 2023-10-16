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
        [ForeignKey(nameof(BangLuong))]
        public string MaBangLuong {  get; set; }
        public CTBangLuong CTBangLuongBangLuong {  set; get; }

        [Required]
        [StringLength(10)]
        [ForeignKey (nameof(KyLuong))]
        public string MaKyLuong { get; set; }
        public CTBangLuong CTBangLuongKyLuong { get; set; }

        [Required]
        [StringLength(10)]
        [ForeignKey(nameof(NhanVien))]
        public string MaNhanVien {  get; set; }
        public CTBangLuong CTBangLuongNhanVien { get; set; }
        
        [StringLength(10)]
        [ForeignKey(nameof(PhuCap))]
        public string MaPhuCap {  get; set; }
        public CTBangLuong CTBangLuongPhuCap { get; set; }

        [StringLength (10)]
        [ForeignKey(nameof(PhieuUngLuong))]
        public string MaPhieuUng { get; set; }
        public CTBangLuong CTBangLuongPhieuUng { get; set;}

        public float LuongPhuTroi { get; set; }

        public float LuongCoBan { get; set; }

        public float TongLuong {  get; set; }



    }
}

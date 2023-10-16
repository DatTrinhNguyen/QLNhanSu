using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class CTBangCong
    {
        [Required]
        [StringLength(10)]
        [ForeignKey(nameof(MaNhanVien))]
        public string MaNhanVien {  get; set; }
        public NhanVien CTBangCongNhanVien { get; set; }
        

        [Required]
        [StringLength(10)]
        [ForeignKey(nameof(MaLoaiCa))]
        public string MaLoaiCa {  get; set; }
        public LoaiCa CTBangCongLoaiCa { get; set; }

        [Required]
        [StringLength(10)]
        [ForeignKey(nameof(MaLoaiCong))]
        public string MaLoaiCong { get; set; }
        public LoaiCong CTBangCongLoaiCong { get; set; }

        [Required]
        [StringLength(10)]
        [ForeignKey(nameof(MaPhieuPT))]
        public string MaPhieuPT {  get; set; }
        public PhieuPhuTroi CTBangCongPhieuPhuTroi {  get; set; }


        [Required]
        public DateTime Ngay {  get; set; }

        
        public string SoGioLamCoBan { get; set; }
        public string SoGioLamPT { get; set; }

    }
}

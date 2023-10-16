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
        [ForeignKey(nameof(NhanVien))]
        public string MaNhanVien {  get; set; }
        public CTBangCong CTBangCongNhanVien { get; set; }
        

        [Required]
        [StringLength(10)]
        [ForeignKey(nameof(LoaiCa))]
        public string MaLoaiCa {  get; set; }
        public CTBangCong CTBangCongLoaiCa { get; set; }

        [Required]
        [StringLength(10)]
        [ForeignKey(nameof(LoaiCong))]
        public string MaLoaiCong { get; set; }
        public CTBangCong CTBangCongLoaiCong { get; set; }

        [Required]
        [StringLength(10)]
        [ForeignKey(nameof(PhieuPhuTroi))]
        public string MaPhieuPT {  get; set; }
        public CTBangCong CTBangCongPhieuPhuTroi {  get; set; }


        [Required]
        public DateTime Ngay {  get; set; }

        
        public string SoGioLamCoBan { get; set; }
        public string SoGioLamPT { get; set; }

    }
}

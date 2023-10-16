using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class HopDong
    {
        [Key]
        [StringLength(10)]
        public string MaHD {  get; set; }
        [Required][StringLength(10)]
        [ForeignKey(nameof(PhongBan))]
        public string MaPhongBan {  get; set; }
        public HopDong HopDongPhongBan { get; set; }

        [Required][StringLength(10)]
        [ForeignKey(nameof(NhanVien))]
        public string MaNhanVien {  get; set; }
        public HopDong HopDongNhanVien { get; set; }

        [Required][StringLength(10)]
        [ForeignKey(nameof(ChucVu))]
        public string MaChucVu {  get; set; }
        public HopDong HopDongChucVu { get; set; }

        [Required][StringLength(10)]
        [ForeignKey(nameof(QuyetDinh))]
        public string MaQuyetDinh {  get; set; }
        public HopDong HopDongQuyetDinh { get; set; }

        [Required][StringLength(10)]
        [ForeignKey(nameof(CheDoLamViec))]
        public string MaCheDo {  get; set; }
        public HopDong HopDongCheDoLamViec { get; set; }

        [Required]
        [ForeignKey(nameof(LoaiHD))]
        public int IDHD {  get; set; }
        public HopDong HopDongLoaiHD { get; set; }

        [Required]
        public float NgayKy {  get; set; }

    }
}

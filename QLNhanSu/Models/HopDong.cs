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
        [ForeignKey(nameof(MaPhongBan))]
        public string MaPhongBan {  get; set; }
        public PhongBan HopDongPhongBan { get; set; }

        [Required][StringLength(10)]
        [ForeignKey(nameof(MaNhanVien))]
        public string MaNhanVien {  get; set; }
        public NhanVien HopDongNhanVien { get; set; }

        [Required][StringLength(10)]
        [ForeignKey(nameof(MaChucVu))]
        public string MaChucVu {  get; set; }
        public ChucVu HopDongChucVu { get; set; }

        [Required][StringLength(10)]
        [ForeignKey(nameof(MaQuyetDinh))]
        public string MaQuyetDinh {  get; set; }
        public QuyetDinh HopDongQuyetDinh { get; set; }

        [Required][StringLength(10)]
        [ForeignKey(nameof(MaCheDo))]
        public string MaCheDo {  get; set; }
        public CheDoLamViec HopDongCheDoLamViec { get; set; }

        [Required]
        [ForeignKey(nameof(IDHD))]
        public int IDHD {  get; set; }
        public LoaiHD HopDongLoaiHD { get; set; }

        [Required]
        public float NgayKy {  get; set; }

        public BaoHiemNhanVien HopDongBaoHiemNhanVien {  get; set; }
        public CTHopDong CTHopDongHopDong {  get; set; }

    }
}

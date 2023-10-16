using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class PhieuPhuTroi
    {
        [Key]
        [StringLength(10)]
        public string MaPhieuPT {  get; set; }

        [Required]
        public DateTime NgayPT { get; set; }

        [Required]   
        public double SoGioPT {  get; set; }
        public CTBangCong CTBangCongPhieuPhuTroi { get; set; }
    }
}

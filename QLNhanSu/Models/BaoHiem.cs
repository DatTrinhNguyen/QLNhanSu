using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class BaoHiem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string TenBH { get; set; }
        public BaoHiemNhanVien BaoHiemNhanVienBaoHiem { get; set; }
    }
}

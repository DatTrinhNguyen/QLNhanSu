using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    public class NghiPhep
    {
        [Key]
        [StringLength(10)]
        public string MaNghiPhep {  get; set; }

        [Required]
        [StringLength(10)]
        [ForeignKey(nameof(MaNhanVien))]
        public string MaNhanVien {  get; set; }
        public NhanVien NghiPhepNhanVien { get; set; }
        
        public DateTime NgayNghi { get; set; }
    }
}

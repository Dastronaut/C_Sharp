using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190156_TranKimTienDat
{
    public class NCC
    {
        [Key]
        public int MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string MaTP { get; set; }
        [ForeignKey("MaTP")]
        public virtual DC DC { get; set; }

        public ICollection<SanPham> SPs { get; set; }
        public NCC()
        {
            SPs = new HashSet<SanPham>();
        }
    }
}

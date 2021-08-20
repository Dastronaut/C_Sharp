using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class LoaiHang
    {
        [Key]
        public int ID_LoaiHang { get; set; }
        public string TenLoaiHang { get; set; }

        public ICollection<SanPham> SPs { get; set; }
        public LoaiHang()
        {
            SPs = new HashSet<SanPham>();
        }
        public override string ToString()
        {
            return TenLoaiHang;
        }
    }
}

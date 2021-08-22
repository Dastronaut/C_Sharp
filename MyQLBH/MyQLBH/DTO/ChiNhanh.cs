using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQLBH
{
    public class ChiNhanh
    {
        [Key]
        public int ID_ChiNhanh { get; set; }
        public string TenChiNhanh { get; set; }

        public ICollection<KhachHang> KHs { get; set; }
        public ChiNhanh()
        {
            KHs = new HashSet<KhachHang>();
        }

    }
}

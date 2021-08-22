using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public class TheLoai
    {
        [Key]
        public int ID_TheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public ICollection<Sach> Sachs { get; set; }
        public TheLoai()
        {
            Sachs = new HashSet<Sach>();
        }
    }
}

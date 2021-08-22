using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReviewApp
{
    public class LoaiHang
    {
        [Key]
        public int ID_LoaiHang { get; set; }
        public string TenLH { get; set; }
        public ICollection<Sanpham> SPs { get; set; }
        public LoaiHang()
        {
            SPs = new HashSet<Sanpham>();
        }
    }
}

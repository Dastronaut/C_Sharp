using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReviewApp
{
    public class Sanpham
    {
        [Key]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int ID_LoaiHang { get; set; }
        public Sanpham()
        {

        }
        public Sanpham(string masp, string tensp, int id_loaihang)
        {
            this.MaSP = masp;
            this.TenSP = tensp;
            this.ID_LoaiHang = id_loaihang;
        }
        [ForeignKey("ID_LoaiHang")]
        public virtual LoaiHang LoaiHang { get; set; }
    }
}

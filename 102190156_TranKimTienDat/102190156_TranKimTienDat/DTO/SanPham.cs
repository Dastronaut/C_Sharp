using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190156_TranKimTienDat
{
    public class SanPham
    {
        [Key]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public float Gia { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuong { get; set; }
        public int MaNCC { get; set; }
        public SanPham() { }
        public SanPham(string ma, string ten, float gia, DateTime dt, int sl, int mancc) 
        {
            this.MaSP = ma;
            this.TenSP = ten;
            this.Gia = gia;
            this.NgayNhap = dt;
            this.SoLuong = sl;
            this.MaNCC = mancc;
        }
        [ForeignKey("MaNCC")]
        public virtual NCC NCC { get; set; }

        public static bool cmpMaSP(SanPham sp1, SanPham sp2)
        {
            if (string.Compare(sp1.MaSP, sp2.MaSP) > 0) return true;
            return false;
        }
        public static bool cmpTenSP(SanPham sp1, SanPham sp2)
        {
            if (string.Compare(sp1.TenSP, sp2.TenSP) > 0) return true;
            return false;
        }
        public static bool cmpGia(SanPham sp1, SanPham sp2)
        {
            if (sp1.Gia > sp2.Gia) return true;
            return false;
        }
    }
}

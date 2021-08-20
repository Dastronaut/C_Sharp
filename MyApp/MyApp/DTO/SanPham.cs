using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class SanPham
    {
        [Key]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonVi { get; set; }
        public double Gia { get; set; }
        public int ID_LoaiHang { get; set; }
        public SanPham() { }
        public SanPham(string masp, string tensp, string donvi, double gia, int id_loaihang)
        {
            this.MaSP = masp;
            this.TenSP = tensp;
            this.DonVi = donvi;
            this.Gia = gia;
            this.ID_LoaiHang = id_loaihang;
        }
        [ForeignKey("ID_LoaiHang")]
        public virtual LoaiHang LoaiHang { get; set; }

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
        public static bool cmpDonVi(SanPham sp1, SanPham sp2)
        {
            if (string.Compare(sp1.DonVi, sp2.DonVi) > 0) return true;
            return false;
        }
        public static bool cmpGia(SanPham sp1, SanPham sp2)
        {
            if (sp1.Gia > sp2.Gia) return true;
            return false;
        }
        public static bool cmpID_LoaiHang(SanPham sp1, SanPham sp2)
        {
            if (sp1.ID_LoaiHang > sp2.ID_LoaiHang) return true;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQLBH
{
    public class KhachHang
    {
        [Key]
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public int Tuoi { get; set; }
        public int ID_ChiNhanh { get; set; }
        public KhachHang() { }
        public KhachHang(string makh, string tenkh, int tuoi, int chinhanh)
        {
            this.MaKH = makh;
            this.TenKH = tenkh;
            this.Tuoi = tuoi;
            this.ID_ChiNhanh = chinhanh;
        }

        [ForeignKey("ID_ChiNhanh")]
        public virtual ChiNhanh ChiNhanh { get; set; }

        public static bool cmpMaKH(KhachHang kh1, KhachHang kh2)
        {
            if (string.Compare(kh1.MaKH, kh2.MaKH) > 0) return true;
            return false;
        }
        public static bool cmpTenKH(KhachHang kh1, KhachHang kh2)
        {
            if (string.Compare(kh1.TenKH, kh2.TenKH) > 0) return true;
            return false;
        }
        public static bool cmpTuoi(KhachHang kh1, KhachHang kh2)
        {
            if (kh1.Tuoi > kh2.Tuoi) return true;
            return false;
        }
        public static bool cmpID_ChiNhanh(KhachHang kh1, KhachHang kh2)
        {
            if (kh1.ID_ChiNhanh > kh2.ID_ChiNhanh) return true;
            return false;
        }
    }
}

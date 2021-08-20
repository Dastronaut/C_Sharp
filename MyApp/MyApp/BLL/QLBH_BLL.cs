using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class QLBH_BLL
    {
        public delegate bool Compare(SanPham s1, SanPham s2);
        public static QLBH_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLBH_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private static QLBH_BLL _Instance;

        public List<SanPham> getAllSP_BLL(string tensp, int id_loaihang)
        {
            return QLBH_DAL.Instance.getAllSP_DAL(tensp, id_loaihang);
        }
        public List<LoaiHang> getAllLH_BLL()
        {
            return QLBH_DAL.Instance.getAllLH_DAL();
        }
        public int addSP_BLL(string masp, string tensp, string donvi, double gia, int id_loaihang)
        {
            return QLBH_DAL.Instance.addSP_DAL(masp, tensp, donvi, gia, id_loaihang);
        }
        public SanPham getSVbyID_BLL(string masp)
        {
            return QLBH_DAL.Instance.getSVbyID_DAL(masp);
        }
        public int editSP_DAL(string masp, string tensp, string donvi, double gia, int id_loaihang)
        {
            return QLBH_DAL.Instance.editSP_DAL(masp, tensp, donvi, gia, id_loaihang);
        }
        public int deleteSP_BLL(string masp)
        {
            return QLBH_DAL.Instance.deleteSP_DAL(masp);
        }
        public List<string> getPropsSP_BLL()
        {
            return QLBH_DAL.Instance.getPropsSP_DAL();
        }
        public List<SanPham> getListSP_BLL(List<string> listmasp)
        {
            return QLBH_DAL.Instance.getListSP_DAL(listmasp);
        }
        public List<SanPham> sortSP(List<SanPham> sps, string prop)
        {
            Compare cmp;
            switch (prop)
            {
                case "MaSP":
                    cmp = SanPham.cmpMaSP;
                    break;
                case "TenSP":
                    cmp = SanPham.cmpTenSP;
                    break;
                case "DonVi":
                    cmp = SanPham.cmpDonVi;
                    break;
                case "Gia":
                    cmp = SanPham.cmpGia;
                    break;
                case "LoaiHang":
                    cmp = SanPham.cmpID_LoaiHang;
                    break;
                default:
                    cmp = SanPham.cmpMaSP;
                    break;
            }
            for (int i = 0; i < sps.Count; i++)
            {
                for (int j = i; j < sps.Count; j++)
                {
                    if (cmp(sps[i], sps[j]))
                    {
                        SanPham tmp = sps[i];
                        sps[i] = sps[j];
                        sps[j] = tmp;
                    }
                }
            }
            return sps;
        }
    }
}

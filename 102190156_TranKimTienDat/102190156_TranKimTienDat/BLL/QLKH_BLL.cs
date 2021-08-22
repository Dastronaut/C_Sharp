using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190156_TranKimTienDat
{
    class QLKH_BLL
    {
        public delegate bool Compare(SanPham s1, SanPham s2);
        public static QLKH_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLKH_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private static QLKH_BLL _Instance;

        public List<DC> getAllTP_BLL()
        {
            return QLKH_DAL.Instance.getAllTP_DAL();
        }

        public List<NCC> getAllNCC_BLL()
        {
            return QLKH_DAL.Instance.getAllNCC_DAL();
        }
        public DataTable getAllSanPham_BLL(string ten, string ncc, string matp)
        {
            return ViewModel(QLKH_DAL.Instance.getAllSanPham_DAL(ten, ncc, matp));
        }
        public int addSP_BLL(string ma, string ten, float gia, DateTime ngay, int sl, int mancc)
        {
            return QLKH_DAL.Instance.addSP_DAL(ma, ten, gia, ngay, sl, mancc);
        }
        public SanPham getSPbyMa_BLL(string ma)
        {
            return QLKH_DAL.Instance.getSPbyMa_DAL(ma);
        }
        public int editSP_BLL(string masp, string tensp, float gia, int soluong, DateTime ngay, int mancc)
        {
            return QLKH_DAL.Instance.editSP_DAL(masp, tensp, gia, soluong, ngay, mancc);
        }

        public int deleteSP_BLL(string masp)
        {
            return QLKH_DAL.Instance.deleteSP_DAL(masp);
        }
        public List<SanPham> getListSP_BLL(List<string> listmasp)
        {
            return QLKH_DAL.Instance.getListSP_DAL(listmasp);
        }

        public DataTable sortSP(List<SanPham> sps, string prop)
        {
            Compare cmp;
            switch (prop)
            {
                case "Ma SP":
                    cmp = SanPham.cmpMaSP;
                    break;
                case "Ten SP":
                    cmp = SanPham.cmpTenSP;
                    break;
                case "Gia":
                    cmp = SanPham.cmpGia;
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
            return ViewModel(sps);
        }
        public DataTable ViewModel(List<SanPham> sps)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Ma SP"),
                new DataColumn("Ten SP"),
                new DataColumn("Gia Nhap", typeof(float)),
                new DataColumn("Ngay Nhap", typeof(DateTime)),
                new DataColumn("Tinh Trang", typeof(bool)),
                new DataColumn("Nha cung cap"),
                new DataColumn("Tinh"),
            });

            foreach (var sp in sps)
            {
                DataRow dr = dt.NewRow();
                dr[0] = sp.MaSP;
                dr[1] = sp.TenSP;
                dr[2] = sp.Gia;
                dr[3] = sp.NgayNhap;
                if (sp.SoLuong > 0)
                {
                    dr[4] = true;
                }
                else
                {
                    dr[4] = false;
                }
                NCC ncc = getNCCbyMaNCC_BLL(sp.MaNCC);
                dr[5] = ncc.TenNCC;
                dr[6] = QLKH_DAL.Instance.gettenTP_DAL(ncc.MaTP);
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public List<NCC> getNCCbyMaTP_BLL(string ma)
        {
            return QLKH_DAL.Instance.getNCCbyMaTP_DAL(ma);
        }
        public NCC getNCCbyMaNCC_BLL(int ma)
        {
            return QLKH_DAL.Instance.getNCCbyMaNCC_DAL(ma);
        }
        public DC getTPbyMaNCC_BLL(int mancc)
        {
            return QLKH_DAL.Instance.getTPbyMaNCC_DAL(mancc);
        }
    }
}

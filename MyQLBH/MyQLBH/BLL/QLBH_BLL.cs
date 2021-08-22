using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQLBH
{
    class QLBH_BLL
    {
        public delegate bool Compare(KhachHang kh1, KhachHang kh2);
        private static QLBH_BLL _Instance { get; set; }
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
            private set
            {

            }
        }
        public DataTable getAllKH_BLL(string tenkh, int idchinhanh)
        {
            return ViewModel(QLBH_DAL.Instance.getAllKH_DAL(tenkh, idchinhanh));
        }
        public List<ChiNhanh> getAllChiNhanh_BLL()
        {
            return QLBH_DAL.Instance.getAllChiNhanh_DAL();
        }
        public int addKhachHang_BLL(string ma, string ten, int tuoi, int idchinhanh)
        {
            return QLBH_DAL.Instance.addKhachHang_DAL(ma, ten, tuoi, idchinhanh);
        }
        public KhachHang getKHbyID_BLL(string makh)
        {
            return QLBH_DAL.Instance.getKHbyID_DAL(makh);
        }
        public int editKH_BLLL(string ma, string ten, int tuoi, int idchinhanh)
        {
            return QLBH_DAL.Instance.editKH_DAL(ma, ten, tuoi, idchinhanh);
        }
        public int deleteKH_BLL(string makh)
        {
            return QLBH_DAL.Instance.deleteKH_DAL(makh);
        }
        public List<string> getListProp_BLL()
        {
            return QLBH_DAL.Instance.getListProp_DAL();
        }

        public List<KhachHang> getListKHbyMaKH_BLL(List<string> makhs)
        {
            return QLBH_DAL.Instance.getListKHbyMaKH_DAL(makhs);
        }
        public DataTable sortListKH(List<KhachHang> khs, string prop)
        {
            Compare cmp;
            switch (prop)
            {
                case "MaKH":
                    cmp = KhachHang.cmpMaKH;
                    break;
                case "TenKH":
                    cmp = KhachHang.cmpTenKH;
                    break;
                case "Tuoi":
                    cmp = KhachHang.cmpTuoi;
                    break;
                case "ID_ChiNhanh":
                    cmp = KhachHang.cmpID_ChiNhanh;
                    break;
                default:
                    cmp = KhachHang.cmpMaKH;
                    break;
            }
            for (int i = 0; i < khs.Count; i++)
            {
                for (int j = i; j < khs.Count; j++)
                {
                    if (cmp(khs[i], khs[j]))
                    {
                        KhachHang tmp = khs[i];
                        khs[i] = khs[j];
                        khs[j] = tmp;
                    }
                }
            }
            return ViewModel(khs);
        }
        private DataTable ViewModel(List<KhachHang> khs)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MaKH"),
                new DataColumn("Tên KH"),
                new DataColumn("Tuổi", typeof(int)),
                new DataColumn("Chi Nhánh"),
            });

            foreach (var kh in khs)
            {
                DataRow dr = dt.NewRow();
                dr["MaKH"] = kh.MaKH;
                dr["Tên KH"] = kh.TenKH;
                dr["Tuổi"] = kh.Tuoi;
                dr["Chi Nhánh"] = QLBH_DAL.Instance.getChiNhanhbyID_DAL(kh.ID_ChiNhanh);
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}

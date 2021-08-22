using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190156_TranKimTienDat
{
    class QLKH_DAL
    {
        public static QLKH_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLKH_DAL();
                }
                return _Instance;
            }
            private set { }
        }
        private static QLKH_DAL _Instance;
        public DC get1TP(DataRow dr)
        {
            DC dc = new DC();
            dc.MaTP = dr[0].ToString();
            dc.TenTP = dr[1].ToString();
            return dc;
        }
        public List<DC> getAllTP_DAL()
        {
            List<DC> dcs = new List<DC>();
            string query = "SELECT * FROM DCs";
            foreach (DataRow dr in DBHelper.Instance.getRecord(query).Rows)
            {
                dcs.Add(get1TP(dr));
            }
            return dcs;
        }

        public NCC get1NCC(DataRow dr)
        {
            NCC ncc = new NCC();
            ncc.MaNCC = Convert.ToInt32(dr[0]);
            ncc.TenNCC = dr[1].ToString();
            ncc.MaTP = dr[2].ToString();
            return ncc;
        }
        public List<NCC> getAllNCC_DAL()
        {
            List<NCC> nccs = new List<NCC>();
            string query = "SELECT * FROM NCCs";
            foreach (DataRow dr in DBHelper.Instance.getRecord(query).Rows)
            {
                nccs.Add(get1NCC(dr));
            }
            return nccs;
        }

        private SanPham get1SP(DataRow dr)
        {
            SanPham sp = new SanPham();
            sp.MaSP = dr[0].ToString();
            sp.TenSP = dr[1].ToString();
            sp.Gia = float.Parse(dr[2].ToString());
            sp.NgayNhap = Convert.ToDateTime(dr[3]);
            sp.SoLuong = Convert.ToInt32(dr[4]);
            sp.MaNCC = Convert.ToInt32(dr[5]);
            return sp;
        }

        public List<SanPham> getAllSanPham_DAL(string ten, int ncc)
        {
            List<SanPham> sps = new List<SanPham>();
            string query = "SELECT * FROM SanPhams";
            foreach (DataRow dr in DBHelper.Instance.getRecord(query).Rows)
            {
                if (ncc == 0) 
                {
                    if (ten != "")
                    {
                        if (dr["TenSP"].ToString().ToUpper().Contains(ten.ToUpper()))
                        {
                            sps.Add(get1SP(dr));
                        }
                    }
                    else
                        sps.Add(get1SP(dr));
                }
                else
                {
                    if (ten != "")
                    {
                        if (dr["TenSP"].ToString().ToUpper().Contains(ten.ToUpper()) && Convert.ToInt32(dr["MaNCC"]) == ncc)
                        {
                            sps.Add(get1SP(dr));
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(dr["MaNCC"]) == ncc)
                        {
                            sps.Add(get1SP(dr));
                        }
                    }
                }
            }
            return sps;
        }
        public int addSP_DAL(string ma, string ten, float gia, DateTime ngay, int sl, int mancc)
        {
            string query = "INSERT INTO SanPhams VALUES('" + ma + "', '" + ten + "', " + gia + ", '" + ngay.ToString() + "', " + sl + " , " + mancc + ")";
            return DBHelper.Instance.ExcuteQuery(query);
        }

        public SanPham getSPbyMa_DAL(string ma)
        {
            SanPham sp = new SanPham();
            string query = "SELECT * FROM SanPhams WHERE MaSP = '" + ma + "'";
            return get1SP(DBHelper.Instance.getRecord(query).Rows[0]);
        }

        public int editSP_DAL(string masp, string tensp, float gia, int soluong, DateTime ngay, int mancc)
        {
            string query = "UPDATE SanPhams SET TenSP = '" + tensp + "', NgayNhap = '" + ngay.ToString()
                + "', Gia = " + gia + ", SoLuong = " + soluong + ", MaNCC = " + mancc + " WHERE MaSP = '" + masp + "'";
            return DBHelper.Instance.ExcuteQuery(query);
        }
        public int deleteSP_DAL(string masp)
        {
            string query = "DELETE FROM SanPhams WHERE MaSP = '" + masp + "'";
            return DBHelper.Instance.ExcuteQuery(query);
        }

        public List<SanPham> getListSP_DAL(List<string> listmasp)
        {
            List<SanPham> sps = new List<SanPham>();
            foreach (string masp in listmasp)
            {
                sps.Add(getSPbyMa_DAL(masp));
            }
            return sps;
        }
        public NCC getNCC_DAL(int ma)
        {
            string query = "SELECT * FROM NCCs WHERE MaNCC = " + ma;
            return get1NCC(DBHelper.Instance.getRecord(query).Rows[0]);
        }
        public string gettenTP_DAL(string matp)
        {
            string query = "SELECT TenTP FROM DCs WHERE MaTP = '" + matp + "'";
            return DBHelper.Instance.getRecord(query).Rows[0]["TenTP"].ToString();
        }
    }
}

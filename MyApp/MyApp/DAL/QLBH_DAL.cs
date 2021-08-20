using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class QLBH_DAL
    {
        public static QLBH_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLBH_DAL();
                }
                return _Instance;
            }
            private set { }
        }
        private static QLBH_DAL _Instance;

        public List<SanPham> getAllSP_DAL(string tensp, int id_loaihang) 
        {
            List<SanPham> sps = new List<SanPham>();
            string query = "SELECT * FROM SanPhams";
            foreach (DataRow dr in DBHelper.Instance.getRecord(query).Rows)
            {
                if (id_loaihang == 0)
                {
                    if (tensp != "")
                    {
                        if (dr[1].ToString().ToUpper().Contains(tensp.ToUpper()))
                        {
                            sps.Add(get1SP(dr));
                        }
                    }
                    else
                        sps.Add(get1SP(dr));
                }
                else
                {
                    if (tensp != "")
                    {
                        if (dr[1].ToString().ToUpper().Contains(tensp.ToUpper()) && Convert.ToInt32(dr[4]) == id_loaihang)
                        {
                            sps.Add(get1SP(dr));
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(dr[4]) == id_loaihang)
                        {
                            sps.Add(get1SP(dr));
                        }
                    }
                }
            }
            return sps;
        }
        private SanPham get1SP(DataRow dr)
        {
            SanPham sp = new SanPham();
            sp.MaSP = dr[0].ToString();
            sp.TenSP = dr[1].ToString();
            sp.DonVi = dr[2].ToString();
            sp.Gia = Convert.ToDouble(dr[3]);
            sp.ID_LoaiHang = Convert.ToInt32(dr[4]);
            return sp;
        }

        private LoaiHang get1LH(DataRow dr)
        {
            LoaiHang lh = new LoaiHang();
            lh.ID_LoaiHang = Convert.ToInt32(dr[0]);
            lh.TenLoaiHang = dr[1].ToString();
            return lh;
        }
        public List<LoaiHang> getAllLH_DAL()
        {
            List<LoaiHang> lhs = new List<LoaiHang>();
            string query = "SELECT * FROM LoaiHangs";
            foreach (DataRow dr in DBHelper.Instance.getRecord(query).Rows)
            {
                lhs.Add(get1LH(dr));
            }
            return lhs;
        }
        public int addSP_DAL(string masp, string tensp, string donvi, double gia, int id_loaihang)
        {
            string query = "INSERT INTO SanPhams VALUES ('" + masp + "', '" + tensp + "', '" + donvi + "', " + gia + ", " + id_loaihang + ")";
            return DBHelper.Instance.ExcuteQuery(query);
        }

        public SanPham getSVbyID_DAL(string masp)
        {
            SanPham sp = new SanPham();
            string query = "SELECT * FROM SanPhams WHERE MaSP = '" + masp + "'";
            return get1SP(DBHelper.Instance.getRecord(query).Rows[0]);
        }
        public int editSP_DAL(string masp, string tensp, string donvi, double gia, int id_loaihang)
        {
            string query = "UPDATE SanPhams SET TenSP = '" + tensp + "', DonVi = '" + donvi
                + "', Gia = " + gia + ", ID_LoaiHang = " + id_loaihang + " WHERE MaSP = '" + masp + "'";
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
                sps.Add(getSVbyID_DAL(masp));
            }
            return sps;
        }
        public List<string> getPropsSP_DAL()
        {
            List<string> listprop = new List<string>();
            string query = "SELECT TOP 1 * FROM SanPhams";
            foreach (DataColumn dc in DBHelper.Instance.getRecord(query).Columns)
            {
                listprop.Add(dc.ColumnName);
            }
            return listprop;
        }
    }
}

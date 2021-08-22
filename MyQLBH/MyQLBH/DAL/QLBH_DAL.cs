using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQLBH
{
    class QLBH_DAL
    {
        private static QLBH_DAL _Instance { get; set; }
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
            private set
            {

            }
        }

        private KhachHang get1KH(DataRow dr)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = dr[0].ToString();
            kh.TenKH = dr[1].ToString();
            kh.Tuoi = Convert.ToInt32(dr[2]);
            kh.ID_ChiNhanh = Convert.ToInt32(dr[3]);
            return kh;
        }

        public List<KhachHang> getAllKH_DAL(string tenkh, int idchinhanh)
        {
            List<KhachHang> khs = new List<KhachHang>();
            string query = "SELECT * FROM KhachHangs";
            foreach (DataRow dr in DBHelper.Instance.getRecord(query).Rows)
            {
                if (idchinhanh == 0)
                {
                    if (tenkh != "")
                    {
                        if (dr[1].ToString().ToUpper().Contains(tenkh.ToUpper()))
                        {
                            khs.Add(get1KH(dr));
                        }
                    }
                    else
                        khs.Add(get1KH(dr));
                }
                else
                {
                    if (tenkh != "")
                    {
                        if (dr[1].ToString().ToUpper().Contains(tenkh.ToUpper()) && Convert.ToInt32(dr[3]) == idchinhanh)
                        {
                            khs.Add(get1KH(dr));
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(dr[3]) == idchinhanh)
                        {
                            khs.Add(get1KH(dr));
                        }
                    }
                }
            }
            return khs;
        }
        private ChiNhanh get1CN(DataRow dr)
        {
            ChiNhanh ch = new ChiNhanh();
            ch.ID_ChiNhanh = Convert.ToInt32(dr[0]);
            ch.TenChiNhanh = dr[1].ToString();
            return ch;
        }
        public List<ChiNhanh> getAllChiNhanh_DAL()
        {
            List<ChiNhanh> chs = new List<ChiNhanh>();
            string query = "SELECT * FROM ChiNhanhs";
            foreach (DataRow dr in DBHelper.Instance.getRecord(query).Rows)
            {
                chs.Add(get1CN(dr));
            }
            return chs;
        }

        public int addKhachHang_DAL(string ma, string ten, int tuoi, int idchinhanh)
        {
            string query = "INSERT INTO KhachHangs VALUES('" + ma + "','" + ten + "', " + tuoi + "," + idchinhanh + ")";
            return DBHelper.Instance.ExcuteQuery(query);
        }
        public KhachHang getKHbyID_DAL(string makh)
        {
            KhachHang kh = new KhachHang();
            string query = "SELECT * FROM KhachHangs WHERE MaKH = '" + makh + "'";
            return get1KH(DBHelper.Instance.getRecord(query).Rows[0]);
        }
        public int editKH_DAL(string ma, string ten, int tuoi, int idchinhanh)
        {
            string query = "UPDATE KhachHangs SET TenKH = '" + ten + "', Tuoi = "
                + tuoi + ", ID_ChiNhanh = " + idchinhanh + " WHERE MaKH = '" + ma + "'";
            return DBHelper.Instance.ExcuteQuery(query);
        }
        public int deleteKH_DAL(string makh)
        {
            string query = "DELETE FROM KhachHangs WHERE MaKH = '" + makh + "'";
            return DBHelper.Instance.ExcuteQuery(query);
        }
        public List<string> getListProp_DAL()
        {
            List<string> props = new List<string>();
            string query = "SELECT TOP 1 * FROM KhachHangs";
            foreach (DataColumn dc in DBHelper.Instance.getRecord(query).Columns)
            {
                props.Add(dc.ColumnName);
            }
            return props;
        }
        public List<KhachHang> getListKHbyMaKH_DAL(List<string> makhs)
        {
            List<KhachHang> khs = new List<KhachHang>();
            foreach (string s in makhs)
            {
                khs.Add(getKHbyID_DAL(s));
            }
            return khs;
        } 
        public string getChiNhanhbyID_DAL(int id)
        {
            string query = "SELECT TenChiNhanh FROM ChiNhanhs WHERE ID_ChiNhanh = " + id;
            return DBHelper.Instance.getRecord(query).Rows[0]["TenChiNhanh"].ToString();
        }
    }
}

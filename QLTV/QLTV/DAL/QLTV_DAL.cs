using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class QLTV_DAL
    {
        private static QLTV_DAL _Instance { get; set; }
        public static QLTV_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLTV_DAL();
                }
                return _Instance;
            }
            private set
            {
            }
        }

        public Sach get1Sach(DataRow dr)
        {
            Sach sach = new Sach();
            sach.MaSach = dr[0].ToString();
            sach.TenSach = dr[1].ToString();
            sach.NamXB = Convert.ToInt32(dr[2]);
            sach.ID_TheLoai = Convert.ToInt32(dr[3]);
            return sach;
        }

        public List<Sach> getAllSach_DAL(string ten, int id)
        {
            List<Sach> sachs = new List<Sach>();
            string query = "SELECT * FROM Saches";
            foreach (DataRow dr in DBHelper.Instance.getRecord(query).Rows)
            {
                if (id == 0)
                {
                    if (ten != "")
                    {
                        if (dr[1].ToString().ToUpper().Contains(ten.ToUpper()))
                        {
                            sachs.Add(get1Sach(dr));
                        }
                    }
                    else
                        sachs.Add(get1Sach(dr));
                }
                else
                {
                    if (ten != "")
                    {
                        if (dr[1].ToString().ToUpper().Contains(ten.ToUpper()) && Convert.ToInt32(dr[3]) == id)
                        {
                            sachs.Add(get1Sach(dr));
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(dr[3]) == id)
                        {
                            sachs.Add(get1Sach(dr));
                        }
                    }
                }
            }
            return sachs;
        }
        public TheLoai get1TheLoai(DataRow dr)
        {
            TheLoai tl = new TheLoai();
            tl.ID_TheLoai = Convert.ToInt32(dr[0]);
            tl.TenTheLoai = dr[1].ToString();
            return tl;
        }

        public List<TheLoai> getAllTheLoai_DAL()
        {
            List<TheLoai> theloais = new List<TheLoai>();
            string query = "SELECT * FROM TheLoais";
            foreach (DataRow dr in DBHelper.Instance.getRecord(query).Rows)
            {
                theloais.Add(get1TheLoai(dr));
            }
            return theloais;
        }

        public int addSach_DAL(string ma, string ten, int nam, int id)
        {
            string query = "INSERT INTO Saches VALUES('" + ma + "','" + ten + "', " + nam + "," + id + ")";
            return DBHelper.Instance.ExcuteQuery(query);
        }
        public Sach getSachbyID_DAL(string ma)
        {
            Sach sach = new Sach();
            string query = "SELECT * FROM Saches WHERE MaSach = '" + ma + "'";
            return get1Sach(DBHelper.Instance.getRecord(query).Rows[0]);
        }
        public int editSach_DAL(string ma, string ten, int nam, int id)
        {
            string query = "UPDATE Saches SET TenSach = '" + ten + "', NamXB = "
                + nam + ", ID_TheLoai = " + id + " WHERE MaSach = '" + ma + "'";
            return DBHelper.Instance.ExcuteQuery(query);
        }
        public int deleteSach_DALL(string ma)
        {
            string query = "DELETE FROM Saches WHERE MaSach = '" + ma + "'";
            return DBHelper.Instance.ExcuteQuery(query);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQSLV_UsingSQL
{
    class QLSV_DAL
    {
        public static QLSV_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLSV_DAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static QLSV_DAL _Instance;
        public List<SV> getAllSV_DAL(int ID_Lop, string NameSV)
        {
            List<SV> SVs = new List<SV>();
            string query = "SELECT * FROM SV";
            foreach (DataRow dr in DBHelper.Instance.getRecord(query).Rows)
            {
                if (ID_Lop == 0)
                {
                    if (NameSV != "")
                    {
                        if (dr["NameSV"].ToString().ToUpper().Contains(NameSV.ToUpper())) SVs.Add(get1SV(dr));
                    }
                    else SVs.Add(get1SV(dr));
                }
                else
                {
                    if (NameSV != "")
                    {
                        if (Convert.ToInt32(dr["ID_Lop"]) == ID_Lop && dr["NameSV"].ToString().ToUpper().Contains(NameSV.ToUpper()))
                        {
                            SVs.Add(get1SV(dr));
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(dr["ID_Lop"]) == ID_Lop) SVs.Add(get1SV(dr));
                    }
                }
            }
            return SVs;
        }

        private SV get1SV(DataRow dr)
        {
            SV sv = new SV();
            sv.MSSV = dr["MSSV"].ToString();
            sv.NameSV = dr["NameSV"].ToString();
            sv.Gender = Convert.ToBoolean(dr["Gender"]);
            sv.NS = Convert.ToDateTime(dr["NS"]);
            sv.ID_Lop = Convert.ToInt32(dr["ID_Lop"]);
            return sv;
        }

        public List<LSH> getAllLSH_DAL()
        {
            List<LSH> LSHs = new List<LSH>();
            string query = "SELECT * FROM LSH";
            foreach (DataRow dr in DBHelper.Instance.getRecord(query).Rows)
            {
                LSHs.Add(get1LSH(dr));
            }
            return LSHs;
        }

        private LSH get1LSH(DataRow dr)
        {
            LSH lsh = new LSH();
            lsh.ID_Lop = Convert.ToInt32(dr["ID_Lop"]);
            lsh.NameLop = dr["NameLSH"].ToString();
            return lsh;
        }
        public string getNameLop_DAL(int id_lop)
        {
            string query = "SELECT NameLSH FROM LSH WHERE ID_Lop = " + id_lop;
            return DBHelper.Instance.getRecord(query).Rows[0]["NameLSH"].ToString();
        }
        public List<string> getProps_DAL()
        {
            List<string> props = new List<string>();
            string query = "SELECT TOP 1 * FROM SV";
            foreach (DataColumn dc in DBHelper.Instance.getRecord(query).Columns)
            {
                props.Add(dc.ColumnName);
            }
            return props;
        }

        public int insertSV_DAL(SV sv)
        {
            string query = "INSERT INTO SV VALUES ('" + sv.MSSV + "', '" + sv.NameSV + "', '" + sv.Gender
                + "', '" + sv.NS + "', " + sv.ID_Lop + ")";
            return DBHelper.Instance.ExcuteDB(query);
        }

        public int updateSV_DAL(SV sv)
        {
            string query = "UPDATE SV SET NameSV = '" + sv.NameSV + "', Gender = '" + sv.Gender + "', NS = '" + sv.NS
                + "', ID_Lop = " + sv.ID_Lop + " WHERE MSSV = '" + sv.MSSV + "'";
            return DBHelper.Instance.ExcuteDB(query);
        }

        public SV getSVByMSSV_DAL(string mssv)
        {
            string query = "SELECT * FROM SV WHERE MSSV = '" + mssv + "'";
            return get1SV(DBHelper.Instance.getRecord(query).Rows[0]);
        }
        public int deleteSV_DAL(string mssv)
        {
            string query = "DELETE FROM SV WHERE MSSV = '" + mssv + "'";
            Console.WriteLine(query);
            return DBHelper.Instance.ExcuteDB(query);
        }
        public List<SV> getListSV_DAL(List<string> listmssv)
        {
            List<SV> svs = new List<SV>();
            string query = "SELECT * FROM SV WHERE MSSV = ";
            foreach (var i in listmssv)
            {
                svs.Add(get1SV(DBHelper.Instance.getRecord(query + i).Rows[0]));
            }
            return svs;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQSLV_UsingSQL
{
    class QLSV_BLL
    {
        public delegate bool Compare(SV s1, SV s2);
        public static QLSV_BLL Instane
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLSV_BLL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static QLSV_BLL _Instance;
        public DataTable getAllSV_BLL(int ID_Lop, string NameSV)
        {
            return ViewModel(QLSV_DAL.Instance.getAllSV_DAL(ID_Lop, NameSV));
        }
        public bool isSVExisted(string newmssv)
        {
            foreach (var i in QLSV_DAL.Instance.getAllSV_DAL(0, ""))
            {
                if (i.MSSV == newmssv)
                {
                    return true;
                }
            }
            return false;
        }
        public List<LSH> getAllLSH_BLL()
        {
            return QLSV_DAL.Instance.getAllLSH_DAL();
        }
        private DataTable ViewModel(List<SV> svs)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV"),
                new DataColumn("NameSV"),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("NS", typeof(DateTime)),
                new DataColumn("NameLop"),
            });

            foreach (var sv in svs)
            {
                DataRow dr = dt.NewRow();
                dr["MSSV"] = sv.MSSV;
                dr["NameSV"] = sv.NameSV;
                dr["Gender"] = sv.Gender;
                dr["NS"] = sv.NS;
                dr["NameLop"] = QLSV_DAL.Instance.getNameLop_DAL(sv.ID_Lop);
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public List<string> getProps_BLL()
        {
            return QLSV_DAL.Instance.getProps_DAL();
        }
        public int insertSV_DAL(SV sv)
        {
            return QLSV_DAL.Instance.insertSV_DAL(sv);
        }
        public int updateSV_BLL(SV sv)
        {
            return QLSV_DAL.Instance.updateSV_DAL(sv);
        }
        public SV getSVByMSSV_BLL(string mssv)
        {
            return QLSV_DAL.Instance.getSVByMSSV_DAL(mssv);
        }
        public int deleteSV_BLL(string mssv)
        {
            return QLSV_DAL.Instance.deleteSV_DAL(mssv);
        }
        public List<SV> getListSV_BLL(List<string> listmssv)
        {
            return QLSV_DAL.Instance.getListSV_DAL(listmssv);
        }
        public DataTable sortSVBy_BLL(List<SV> svs, string prop)
        {
            Compare cmp;
            switch (prop)
            {
                case "MSSV":
                    cmp = SV.cmpMSSV;
                    break;
                case "NameSV":
                    cmp = SV.cmpNameSV;
                    break;
                case "Gender":
                    cmp = SV.cmpGender;
                    break;
                case "NS":
                    cmp = SV.cmpNS;
                    break;
                case "ID_Lop":
                    cmp = SV.cmpID_Lop;
                    break;
                default:
                    cmp = SV.cmpMSSV;
                    break;
            }

            for (int i = 0; i < svs.Count; i++)
            {
                for (int j = i + 1; j < svs.Count; j++)
                {
                    if (cmp(svs[i], svs[j]))
                    {
                        SV temp = svs[i];
                        svs[i] = svs[j];
                        svs[j] = temp;
                    }
                }
            }
            return ViewModel(svs);
        }
    }
}

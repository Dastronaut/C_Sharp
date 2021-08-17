using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQSLV_UsingSQL
{
    class QLSV_BLL
    {
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
        public List<SV> getAllSV_BLL(int ID_Lop, string NameSV)
        {
            return QLSV_DAL.Instance.getAllSV_DAL(ID_Lop, NameSV);
        }

        public List<LSH> getAllLSH_BLL()
        {
            return QLSV_DAL.Instance.getAllLSH_DAL();
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
    }
}

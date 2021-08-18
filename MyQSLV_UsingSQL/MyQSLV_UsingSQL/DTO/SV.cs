using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQSLV_UsingSQL
{
    class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; }
        public DateTime NS { get; set; }
        public int ID_Lop { get; set; }

        public static bool cmpMSSV(SV sv1, SV sv2)
        {
            if (String.Compare(sv1.MSSV, sv2.MSSV) > 0) return true;
            return false;
        }
        public static bool cmpNameSV(SV sv1, SV sv2)
        {
            if (String.Compare(sv1.NameSV, sv2.NameSV) > 0) return true;
            return false;
        }
        public static bool cmpGender(SV sv1, SV sv2)
        {
            if (!sv1.Gender && sv2.Gender) return true;
            return false;
        }
        public static bool cmpNS(SV sv1, SV sv2)
        {
            if (sv1.NS > sv2.NS) return true;
            return false;
        }
        public static bool cmpID_Lop(SV sv1, SV sv2)
        {
            if (sv1.ID_Lop > sv2.ID_Lop) return true;
            return false;
        }
    }
}

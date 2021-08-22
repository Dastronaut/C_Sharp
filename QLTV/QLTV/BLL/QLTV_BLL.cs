using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class QLTV_BLL
    {
        private static QLTV_BLL _Instance { get; set; }
        public static QLTV_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLTV_BLL();
                }
                return _Instance;
            }
            private set
            {
            }
        }
        public List<Sach> getAllSach_BLL(string ten, int id)
        {
            return QLTV_DAL.Instance.getAllSach_DAL(ten, id);
        }
        public List<TheLoai> getAllTheLoai_BLL()
        {
            return QLTV_DAL.Instance.getAllTheLoai_DAL();
        }
        public int addSach_BLL(string ma, string ten, int nam, int id)
        {
            return QLTV_DAL.Instance.addSach_DAL(ma, ten, nam, id);
        }
        public Sach getSachbyID_BLLL(string ma)
        {
            return QLTV_DAL.Instance.getSachbyID_DAL(ma);
        }
        public int editSach_BLL(string ma, string ten, int nam, int id)
        {
            return QLTV_DAL.Instance.editSach_DAL(ma, ten, nam, id);
        }
        public int deleteSach_BLL(string ma)
        {
            return QLTV_DAL.Instance.deleteSach_DALL(ma);
        }
    }
}

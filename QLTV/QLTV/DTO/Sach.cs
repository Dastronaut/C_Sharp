using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public class Sach
    {
        [Key]
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int NamXB { get; set; }
        public int ID_TheLoai { get; set; }
        public Sach() { }
        public Sach(string ma, string ten, int nam, int id) 
        {
            this.MaSach = ma;
            this.TenSach = ten;
            this.NamXB = nam;
            this.ID_TheLoai = id;
        }
        [ForeignKey("ID_TheLoai")]
        public virtual TheLoai TheLoai { get; set; }

    }
}

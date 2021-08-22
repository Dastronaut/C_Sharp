using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QLTV
{
    class CreateDB: CreateDatabaseIfNotExists<CSDL>
    {
        protected override void Seed(CSDL context)
        {
            context.Sachs.AddRange(new Sach[]
            {
                new Sach("Sach 1", "Ten 1", 2001, 1),
                new Sach("Sach 6", "Ten 6", 2009, 2),
                new Sach("Sach 5", "Ten 5", 2002, 1),
                new Sach("Sach 8", "Ten 8", 2005, 2),
                new Sach("Sach 2", "Ten 2", 2008, 1),
                new Sach("Sach 3", "Ten 3", 2003, 2),
            });
            context.TheLoais.AddRange(new TheLoai[]
            {
                new TheLoai() { ID_TheLoai = 1, TenTheLoai = "Trinh Tham"},
                new TheLoai() { ID_TheLoai = 2, TenTheLoai = "Chinh Kich"},
            });
        }
    }
}

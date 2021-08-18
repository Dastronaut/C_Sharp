using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyCodeFirst_NonMigration
{
    class CreateDB: CreateDatabaseIfNotExists<CSDL>
    {
        protected override void Seed(CSDL context)
        {
            context.SVs.AddRange(new SV[]
            {
                new SV() {MSSV = "1", NameSV = "NVA", Gender = true, ID_Lop = 1},
                new SV() {MSSV = "2", NameSV = "NVH", Gender = true, ID_Lop = 2},
                new SV() {MSSV = "3", NameSV = "NVE", Gender = false, ID_Lop = 2},
                new SV() {MSSV = "4", NameSV = "NVD", Gender = false, ID_Lop = 1},
                new SV() {MSSV = "5", NameSV = "NVA", Gender = true, ID_Lop = 2},
                new SV() {MSSV = "6", NameSV = "NVC", Gender = false, ID_Lop = 1},
            });
            context.LSHes.AddRange(new LSH[]
            {
                new LSH() {ID_Lop = 1, NameLop = "Lop 1"},
                new LSH() {ID_Lop = 2, NameLop = "Lop 2"},
            });
        }
    }
}

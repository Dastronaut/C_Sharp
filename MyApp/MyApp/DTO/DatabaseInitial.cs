using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyApp
{
    class DatabaseInitial: CreateDatabaseIfNotExists<CSDL>
    {
        protected override void Seed(CSDL context)
        {
            context.SPs.AddRange(new SanPham[] { 
                new SanPham("SP1", "Huda", "Lon", 20000, 1),
                new SanPham("SP5", "Ostar", "Goi", 12000, 2),
                new SanPham("SP3", "Tiger", "Lon", 22000, 1),
                new SanPham("SP7", "Rong bien", "Goi", 15000, 2),
                new SanPham("SP2", "Bento", "Goi", 50000, 2),
                new SanPham("SP6", "Larue", "Lon", 21000, 1),
                new SanPham("SP4", "Sticks", "Goi", 16000, 2),
                new SanPham("SP8", "Nutriboost", "Chai", 15000, 1),
            });

            context.LHs.AddRange(new LoaiHang[]
            {
                new LoaiHang() {ID_LoaiHang = 1, TenLoaiHang = "Nuoc"},
                new LoaiHang() {ID_LoaiHang = 2, TenLoaiHang = "Banh"},
            });
        }
    }
}

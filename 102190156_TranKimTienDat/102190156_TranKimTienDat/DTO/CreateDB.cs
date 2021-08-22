using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _102190156_TranKimTienDat
{
    class CreateDB : CreateDatabaseIfNotExists<CSDL>
    {
        protected override void Seed(CSDL context)
        {
            context.SPs.AddRange(new SanPham[]
            {
                new SanPham("SP1", "Ten 1", 120000, DateTime.Now, 12, 1),
                new SanPham("SP5", "Ten 5", 160000, DateTime.Now, 0, 2),
                new SanPham("SP4", "Ten 4", 180000, DateTime.Now, 13, 2),
                new SanPham("SP2", "Ten 2", 120000, DateTime.Now, 0, 3),
                new SanPham("SP3", "Ten 3", 110000, DateTime.Now, 1, 6),
            });
            context.NCCs.AddRange(new NCC[]
            {
                new NCC() {MaNCC = 1, TenNCC = "Hai Chau", MaTP = "DN1"},
                new NCC() {MaNCC = 2, TenNCC = "Son Tra", MaTP = "DN1"},
                new NCC() {MaNCC = 3, TenNCC = "Hoa Vang", MaTP = "DN1"},
                new NCC() {MaNCC = 4, TenNCC = "Dien Ban", MaTP = "QN1"},
                new NCC() {MaNCC = 5, TenNCC = "Dien Tho", MaTP = "QN1"},
                new NCC() {MaNCC = 6, TenNCC = "Duy Xuyen", MaTP = "QN1"},
            });
            context.DCs.AddRange(new DC[]
            {
                new DC() { MaTP = "DN1", TenTP = "Da Nang"},
                new DC() { MaTP = "QN1", TenTP = "Quang Nam"},
            });
            
        }
    }
}

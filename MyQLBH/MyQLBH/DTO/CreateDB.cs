using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyQLBH
{
    class CreateDB: CreateDatabaseIfNotExists<CSDL>
    {
        protected override void Seed(CSDL context)
        {
            context.KHs.AddRange(new KhachHang[]
            {
                new KhachHang("KH1", "NVA", 20, 1),
                new KhachHang("KH2", "NVE", 28, 2),
                new KhachHang("KH3", "NVD", 22, 1),
                new KhachHang("KH4", "NVZ", 26, 2),
                new KhachHang("KH5", "NVF", 29, 1),
                new KhachHang("KH6", "NVC", 24, 2),
                new KhachHang("KH7", "NVB", 30, 1),
            });
            context.CHs.AddRange(new ChiNhanh[]
            {
                new ChiNhanh() {ID_ChiNhanh = 1, TenChiNhanh = "Da Nang"},
                new ChiNhanh() {ID_ChiNhanh = 2, TenChiNhanh = "Binh Thuan"},
            });
        }
    }
}

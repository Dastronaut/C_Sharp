using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyReviewApp
{
    class CreateDB: CreateDatabaseIfNotExists<CSDL>
    {
        protected override void Seed(CSDL context)
        {
            context.SPs.AddRange(new Sanpham[] {
                new Sanpham("SP1", "San pham 1", 1),
                new Sanpham("SP2", "San pham 2", 2),
                new Sanpham("SP3", "San pham 3", 1),
                new Sanpham("SP4", "San pham 4", 2),
                new Sanpham("SP5", "San pham 5", 1),
                new Sanpham("SP6", "San pham 6", 2),
                new Sanpham("SP7", "San pham 7", 1),
            });
            context.LHs.AddRange(new LoaiHang[]
            {
                new LoaiHang() {ID_LoaiHang = 1, TenLH = "Loai hang 1"},
                new LoaiHang() {ID_LoaiHang = 2, TenLH = "Loai hang 2"},
            });
        }
    }
}

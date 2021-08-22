using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190156_TranKimTienDat
{
    public class DC
    {

        [Key]
        public string MaTP { get; set; }
        public string TenTP { get; set; }
        public ICollection<NCC> NCCs { get; set; }
        public DC()
        {
            NCCs = new HashSet<NCC>();
        }
    }
}

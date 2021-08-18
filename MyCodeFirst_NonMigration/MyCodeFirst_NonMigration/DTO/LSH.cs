using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeFirst_NonMigration
{
    public class LSH
    {
        [Key]
        public int ID_Lop { get; set; }
        public string NameLop { get; set; }

        public ICollection<SV> SVs { get; set; }
        public LSH()
        {
            SVs = new HashSet<SV>();
        }
        public override string ToString()
        {
            return NameLop;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Street
    {
        [Key]
        public int StreetID { get; set; }
        [StringLength(500)]
        public string StreetName { get; set; }
        public int NeighbourhoodID { get; set; }
    }
}

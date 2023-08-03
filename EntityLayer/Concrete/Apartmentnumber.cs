using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Apartmentnumber
    {
        [Key]
        public int ApartmentnumberID { get; set; }
        [StringLength(20)]
        public String apartmentnumber { get; set; }
        public int BuildingNumberID { get; set; }
    }
}

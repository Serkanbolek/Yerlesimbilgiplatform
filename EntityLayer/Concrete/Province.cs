using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Province
    {
        [Key]
        public int ProvinceID { get; set; }
        [StringLength(20)]
        public string ProvinceName { get; set; }
    }
}

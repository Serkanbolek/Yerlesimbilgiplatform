using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Point
    {
        [Key]
        public int PointID { get; set; }

        public int PointNumber { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}

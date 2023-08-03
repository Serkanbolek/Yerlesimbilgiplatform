﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class District
    {
        public int DistrictID { get; set; }
        [StringLength(200)]
        public string DistrictName { get; set; }
        public int ilID { get; set; }
    }
}

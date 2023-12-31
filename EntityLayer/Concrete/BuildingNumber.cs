﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BuildingNumber
    {
        [Key]
        public int BuildingNumberID { get; set; }
        [StringLength(20)]
        public string BuildingNumberName { get; set; }
        public int StreetID { get; set; }
    }
}

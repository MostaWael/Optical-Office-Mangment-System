﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    public class GlassesType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal ManfacuturePrice { get; set; }
    }
}

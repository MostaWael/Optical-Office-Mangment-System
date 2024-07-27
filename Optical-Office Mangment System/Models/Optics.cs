using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    public  class Optics
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Sph { get; set; }
        public string Cyl { get; set; }

        public int Quantity { get; set; }

        public decimal PriceSell { get; set; }
        public decimal PriceBuy { get; set;}

        public List<DestroyedOptics> DestroyedOptics { get; set; }
        
    }
}

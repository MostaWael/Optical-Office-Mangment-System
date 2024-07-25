using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    internal class BillIteam
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal PriceManfcture {get; set; }
        public decimal TotalPrice { get; set; }

        public Bill Bill { get; set; }
        public Optics optic { get; set; }
    }
}

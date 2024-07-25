using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    internal class SuppliersPayment
    {
        [Key]
        public int Id { get; set; }
        public decimal cost { get; set; }
        public DateTime PaymentAmmount { get; set; }
    }
}

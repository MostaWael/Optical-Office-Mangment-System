using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }
        public string ComapnyName { get; set; }

        public decimal TotalCost { get; set; }

        public List<CustomerPayments> CustomerPayments { get; set; } = new List<CustomerPayments>();
        public List<Bill> Bills { get; set; } = new List<Bill>();
    }

}

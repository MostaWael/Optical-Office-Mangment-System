using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    internal class Bill
    {
        [Key]
        public int Id { get; set; }

        public DateTime BillTimeCreation { get; set; }
        public decimal TotalCost { get; set; }
        public int Number {  get; set; }

        public Customers Customer { get; set; }
        public List<BillIteam> Iteams { get; set; }
    }
}

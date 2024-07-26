using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    internal class Workers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public decimal Salary { get; set; }
        public decimal loses { get; set; } = 0;

        public List<Optics> Optics { get; set; }
        public List<Borrowers> Borrowers { get; set; }
    }
}

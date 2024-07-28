using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    public class Borrowers
    {
        [Key]
        public int Id { get; set; }
        public decimal cost { get; set; }
        public decimal remain { get; set; }
        public DateTime BorrowTime { get; set; } = DateTime.Now;
        
        public Workers Workers { get; set; }
    }
}

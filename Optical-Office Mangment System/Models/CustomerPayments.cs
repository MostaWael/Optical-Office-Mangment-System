using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    public class CustomerPayments
    {
        [Key]
        public int Id { get; set;}
        
        public DateTime PaymentDate { get; set;} = DateTime.Now;
        public decimal PaidTotal { get; set;}
        public decimal Remain { get; set;}
        public int BillNumber { get; set;}
        public string BillState { get; set; } = "باقى منها";
    
        public Customers Customer { get; set;}
    }
}

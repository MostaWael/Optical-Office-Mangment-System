using Optical_Office_Mangment_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.DTOs
{
    public class PaymentDto
    {
        public decimal PaidTotal { get; set; }
        public string CustomerName { get; set; }
    }

    public class DestroyedOpticDto
    {
        public string WorkerName { get; set; }
        public decimal PriceBuy { get; set; }
    }

    public class BillDto
    {
        public decimal BillCost { get; set; }
        public string CustomerName { get; set; }
    }

    public class ReportDto
    {
        public int Number { get; set; }
        public DateTime ReportTime { get; set; }
        public decimal PaymentsTotal { get; set; }
        public decimal LosesTotal { get; set; }
        public decimal BillsTotal { get; set; }

        public List<PaymentDto> payments { get; set; } = new List<PaymentDto>();
        public List<DestroyedOpticDto> DestroyedOptics { get; set; } = new List<DestroyedOpticDto>();
        public List<BillDto> Bills { get; set; } = new List<BillDto>();
    }

}

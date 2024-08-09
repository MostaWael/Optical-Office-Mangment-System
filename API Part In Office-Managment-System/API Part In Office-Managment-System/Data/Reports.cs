using System.ComponentModel.DataAnnotations;

namespace API_Part_In_Office_Managment_System.Data
{
    public class Reports
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime ReportTime { get; set; }
        public decimal PaymentsTotal { get; set; }
        public decimal LosesTotal { get; set; }
        public decimal BillsTotal { get; set; }

        //Relations
        public List<Payment> payments { get; set; } = new List<Payment>();
        public List<DestroyedOptic> DestroyedOptics { get; set; } = new List<DestroyedOptic>();
        public List<Bill> Bills { get; set; } = new List<Bill>();

    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Part_In_Office_Managment_System.Data
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }

        public int Report_id { get; set; }
        //Relation Ship
        [ForeignKey("Report_id")]
        [JsonIgnore]
        public Reports report { get; set; }
    }
}
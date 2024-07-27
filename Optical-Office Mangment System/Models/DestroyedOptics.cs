using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    public class DestroyedOptics
    {
        [Key]
        public int Id { get; set; }
        public int Optics_Id { get; set; }
        public int Workers_Id { get; set; }
        [ForeignKey("Optics_Id")]
        public Optics Optics { get; set; }
        [ForeignKey("Workers_Id")]
        public Workers Workers { get; set; }
    }
}

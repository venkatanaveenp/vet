using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Model
{
     public  class VetSchedule
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Vets")]
        public int VetId { get; set; }
       public  Vets Vets { get; set; }
        //[Column(TypeName ="date")] 
       
        public DateTime SlotDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public bool IsBooked { get; set; }
    }
}

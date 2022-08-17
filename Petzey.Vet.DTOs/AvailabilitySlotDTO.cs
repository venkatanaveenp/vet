using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.DTOs
{
    public class AvailabilitySlotDTO
    {
        public int Id { get; set; }
 
        public int VetId { get; set; }
       
        public DateTime SlotDate { get; set; }
        public TimeSpan StartTime { get; set; }
    }
}

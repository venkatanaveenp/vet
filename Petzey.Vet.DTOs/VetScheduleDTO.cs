using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.DTOs
{
    public class VetScheduleDTO
    {
        
        public int Id { get; set; }
        public DateTime dateTime { get; set; } //30-07-2022:11:00:AM 
        public bool IsAvailable { get; set; }
    }
}

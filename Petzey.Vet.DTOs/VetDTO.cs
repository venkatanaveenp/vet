using Petzey.Vet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.DTOs
{
  public class VetDTO
    {

        public int VetId { get; set; }
        public int NPINum { get; set; }
        public string VetName { get; set; }
        public string Speciality { get; set; }
        public string VetsPicture { get; set; }
        public VetContactInfoDTO ContactInfo { get; set; }
        public string password { get; set; }
         //public ICollection<VetScheduleDTO> AvailabilitySlots { get; set; }

    }
}

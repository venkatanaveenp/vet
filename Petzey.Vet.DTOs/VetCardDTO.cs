using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.DTOs
{
    public class VetCardDTO
    {
        public int VetId { get; set; }
        public int NPINum { get; set; }
        public string VetName { get; set; }
        public string Speciality { get; set; }
        public VetContactInfoDTO VetContactInfoDTO{ get; set; }
        public string VetsPicture { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.DTOs
{
   public  class VetContactInfoDTO
    {
        public int Id { get; set; }
        public string PhoneNum { get; set; }
     

        public string EmailId { get; set; }

        public string ClinicAddress { get; set; }
    }
}

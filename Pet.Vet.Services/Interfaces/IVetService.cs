using Petzey.Vet.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Vet.Services.Interfaces
{
    public  interface IVetService
    {
        ICollection<VetDTO> GetAllVets();
 
        VetDTO AddVet(VetDTO vetDTO);
        bool UpdateVet(VetDTO vetdto);
        VetDTO GetVetById(int VetId);
        VetCardDTO GetProfileDetails(int VetId);
        bool UpdateVetProfile(VetCardDTO vetdto);
        VetCardInPetDTO GetProfilecardinVet(int VetId);
      
    }
}

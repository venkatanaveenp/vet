using Petzey.Vet.DTOs;
using Petzey.Vet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Vet.Services.MappingService
{
    public class VetCardInPetMappingServices
    {
        private ContactInfoMappingServices ContactInfoMapping = new ContactInfoMappingServices();

        public VetCardInPetDTO ConvertToDTO(Vets vets)
        {
            return new VetCardInPetDTO
            {


                Speciality = vets.Speciality,
                VetName = vets.VetName,
                NPINum = vets.NPINum,
                VetsPicture = vets.VetsPicture,
                phoneNo =vets.ContactInfo.PhoneNum,



            };
        }

       





        
        }
    }


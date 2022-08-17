using Petzey.Vet.DTOs;
using Petzey.Vet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Vet.Services.MappingService
{
    public class VetCardMappingService
    {
        private ContactInfoMappingServices ContactInfoMapping = new ContactInfoMappingServices();
        private VetScheduleMappingServices vetScheduleMappingServices = new VetScheduleMappingServices();
        public VetCardDTO ConvertToDTO(Vets vets)
        {
            return new VetCardDTO
            {
                VetId = vets.Id,
                Speciality = vets.Speciality,

                VetName = vets.VetName,
                NPINum= vets.NPINum,
                VetsPicture = vets.VetsPicture,

                VetContactInfoDTO = ContactInfoMapping.ConvertToDTO(vets.ContactInfo)

            };
        }

        public Vets ConvertToModel(VetCardDTO vetDto)
        {
            return new Vets
            {
                Id = vetDto.VetId,
                Speciality = vetDto.Speciality,
                VetName = vetDto.VetName,
                NPINum= vetDto.NPINum,


                VetsPicture = vetDto.VetsPicture,

                ContactInfo = ContactInfoMapping.ConvertToModel(vetDto.VetContactInfoDTO),


            };




        }
    }
}

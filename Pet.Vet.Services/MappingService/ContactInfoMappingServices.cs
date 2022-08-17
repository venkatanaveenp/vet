using Petzey.Vet.DTOs;
using Petzey.Vet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Vet.Services.MappingService
{
    public  class ContactInfoMappingServices
    {
        public ICollection<VetContactInfoDTO> ConvertToDTO(ICollection<VetContactInfo>vetContactInfos)
        {
            ICollection<VetContactInfoDTO> VetContactInfoDTOs = new List<VetContactInfoDTO>();
            if (VetContactInfoDTOs.Count == 0 || VetContactInfoDTOs == null)
            {
                return null;
            }
            foreach (VetContactInfo vetContact in vetContactInfos)
            {
                VetContactInfoDTOs.Add(ConvertToDTO(vetContact));
            }
            return VetContactInfoDTOs;
        }
        
        public VetContactInfoDTO ConvertToDTO(VetContactInfo vetContactInfo )
        {

            return new VetContactInfoDTO
            {
                ClinicAddress= vetContactInfo.ClinicAddress,
                EmailId= vetContactInfo.EmailId,
                Id = vetContactInfo.Id,
                PhoneNum= vetContactInfo.PhoneNum,
               

            };
        }
   
        
        public VetContactInfo ConvertToModel(VetContactInfoDTO vetContactInfoDTO)
        {
            return new VetContactInfo
            {
                ClinicAddress = vetContactInfoDTO.ClinicAddress,
                EmailId = vetContactInfoDTO.EmailId,
                Id = vetContactInfoDTO.Id,
                PhoneNum = vetContactInfoDTO.PhoneNum,
            };
        }
    }
}

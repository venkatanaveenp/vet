using Petzey.Vet.DTOs;
using Petzey.Vet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pet.Vet.Services.MappingService
{
    public class VetMappingService
    {
        private ContactInfoMappingServices ContactInfoMapping = new ContactInfoMappingServices();
        private VetScheduleMappingServices VetScheduleMapping=new VetScheduleMappingServices();
        public ICollection<VetDTO> ConvertToDTO(ICollection<Vets> vets)
        {
            ICollection<VetDTO> vetDTOs = new List<VetDTO>();
            if (vetDTOs.Count == 0 || vetDTOs == null)
            {
                return null;
            }
            foreach (var vet in vets)
            {
                vetDTOs.Add(ConvertToDTO(vet));
            }
            return vetDTOs;
        }
        public VetDTO ConvertToDTO(Vets vets)
        {
            return new VetDTO
            {
                VetId = vets.Id,
                Speciality = vets.Speciality,
                NPINum=vets.NPINum,
                VetsPicture = vets.VetsPicture,
                VetName = vets.VetName,
                //AvailabilitySlots = VetScheduleMapping.ConvertToDTO(vets.VetSchedules),
                password = vets.Password,
                ContactInfo = ContactInfoMapping.ConvertToDTO(vets.ContactInfo)

            };
        }
       
        public Vets ConvertToModel(VetDTO vetDto)
        {
            return new Vets
            {
                Id = vetDto.VetId,
                Speciality = vetDto.Speciality,
                VetName= vetDto.VetName,
                VetsPicture = vetDto.VetsPicture,
                NPINum = vetDto.NPINum,
                Password=   vetDto.password,

                //VetSchedules = VetScheduleMapping.ConvertToModel(vetDto.AvailabilitySlots),



                ContactInfo =ContactInfoMapping.ConvertToModel(vetDto.ContactInfo),
              

            };

        
        }
    }
}

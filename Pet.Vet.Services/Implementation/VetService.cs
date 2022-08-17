using Pet.Vet.Services.Interfaces;
using Pet.Vet.Services.MappingService;
using Petzey.Vet.DTOs;
using Petzey.Vet.Model;
using Petzey.Vet.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Vet.Services.Implementation
{
    public class VetService:IVetService
    {
        private IVetRepository repo;
        private VetMappingService VetMapping;
        private VetCardMappingService CardMappingService;
        VetCardInPetMappingServices vetCardInPetMappingServices;
        public VetService(IVetRepository repo, VetMappingService vetMappingService, VetCardMappingService CardMappingService, VetCardInPetMappingServices vetCardInPetMappingServices)
        {
            this.VetMapping = vetMappingService;
            this.repo = repo;
            this.CardMappingService= CardMappingService;
            this.vetCardInPetMappingServices = vetCardInPetMappingServices;
    }

        public VetDTO AddVet(VetDTO vetDTO)
        {
            var vet = VetMapping.ConvertToModel(vetDTO);
            var result = repo.SaveVet(vet);
            return VetMapping.ConvertToDTO(result);
        }

        public int EditVet(VetDTO vetDTO)
        {
            throw new NotImplementedException();
        }

        public ICollection<VetDTO> GetAllVets()
        {
            ICollection<Vets> vets = repo.GetAllVets();
            ICollection<VetDTO> vetDTO = new List<VetDTO>();
            foreach (var vet in vets)
            {
                vetDTO.Add(VetMapping.ConvertToDTO(vet));
            }
            return vetDTO;

        }
        public bool UpdateVet(VetDTO vetdto)
        {
            var vet=VetMapping.ConvertToModel(vetdto);
            return repo.UpdateVet(vet);
        }
        public  VetDTO GetVetById(int VetId)
        {
            Vets vet =  repo.GetAllDetailsByVetId(VetId);
            return VetMapping.ConvertToDTO(vet);
        }
        public VetCardDTO GetProfileDetails(int VetId)
        {
            Vets vet = repo.GetAllDetailsByVetId(VetId);
            return CardMappingService.ConvertToDTO(vet);
        }
        public bool UpdateVetProfile(VetCardDTO vetdto)
        {
            var vet = CardMappingService.ConvertToModel(vetdto);
            return repo.UpdateVet(vet);
        }
        public VetCardInPetDTO GetProfilecardinVet(int VetId)
        {
            Vets vet = repo.GetAllDetailsByVetId(VetId);
            return vetCardInPetMappingServices.ConvertToDTO(vet);
        }
      
        

    }

}

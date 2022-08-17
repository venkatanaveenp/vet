using Pet.Vet.Services.Interfaces;
using Pet.Vet.Services.MappingService;
using Petzey.Vet.DTOs;
using Petzey.Vet.Model;
using Petzey.Vet.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Vet.Services.Implementation
{
    public class AvaliableSlotService: IAvailabilitySlotServices
    {
 
        AvailabilitySlotRepository repo=new AvailabilitySlotRepository();
       
        public AvailabilitySlotDTO addSlot(AvailabilitySlotDTO slot)
        {
           VetSchedule availabilitySlot = new VetSchedule
            {
                VetId = slot.VetId,
                SlotDate = slot.SlotDate,
                StartTime = slot.StartTime,
          
            };

            var bookedSlot = repo.addSlot(availabilitySlot);
            return new AvailabilitySlotDTO
            {
                Id = bookedSlot.Id,
                VetId = bookedSlot.VetId,
                StartTime = bookedSlot.StartTime,
                SlotDate = bookedSlot.SlotDate,
            };
        }
        public bool ChangeSlotsStatus(int Id,bool IsBooked)
      {
            return repo.UpdateSlot(Id, IsBooked);
        }
    
    

        public ICollection<AvailabilitySlotDTO> getAllAvailableSlotsForADay(int doctorId, DateTime date)
        {
            var slots = repo.getAllSlotsForADay(doctorId, date);
            ICollection<AvailabilitySlotDTO> availableSlots = new List<AvailabilitySlotDTO>();
            foreach (var slot in slots)
            {
                availableSlots.Add(new AvailabilitySlotDTO
                {
                    VetId = slot.VetId,
                    SlotDate = slot.SlotDate,
                    StartTime = slot.StartTime,
                    Id = slot.Id,
                });
            }

            return availableSlots;
        }
    }

}
 

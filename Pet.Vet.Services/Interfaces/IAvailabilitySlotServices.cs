using Petzey.Vet.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Vet.Services.Interfaces
{
  public interface IAvailabilitySlotServices
    {
        ICollection<AvailabilitySlotDTO> getAllAvailableSlotsForADay(int VetId, DateTime date);
        AvailabilitySlotDTO addSlot(AvailabilitySlotDTO slot);
        bool ChangeSlotsStatus(int Id, bool IsBooked);
    }
}

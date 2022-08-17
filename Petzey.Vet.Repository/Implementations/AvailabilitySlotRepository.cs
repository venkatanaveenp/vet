using Petzey.Vet.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Repository.Implementations
{
    public class AvailabilitySlotRepository
    {

        public ICollection<VetSchedule> getAllSlotsForADay(int vetId, DateTime date)
        {
            using (var db = new VetContext1())
            {
                var availabilitySlot = db.Schedules.Where(a => a.VetId == vetId &&
                a.SlotDate.Year == date.Year &&
                a.SlotDate.Month == date.Month &&
                a.SlotDate.Day == date.Day  /*&&
                a.IsBooked*/ ).ToList();
                return availabilitySlot;
              
            }
        }

        public VetSchedule addSlot(VetSchedule availabilitySlot)
        {
            using (var db = new VetContext1())
            {
                db.Schedules.Add(availabilitySlot);
                db.SaveChanges();
                return availabilitySlot;
            }
        } 
   
        public bool UpdateSlot(int SlotId,bool IsBooked)
        {
            var db = new VetContext1();
            var Slot = db.Schedules.Find(SlotId);
            Slot.IsBooked = IsBooked;
            return db.SaveChanges() > 0;
        }
    }
}

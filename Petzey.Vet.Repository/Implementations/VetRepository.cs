using Petzey.Vet.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Petzey.Vet.Repository.Interfaces
{
    public class VetRepository : IVetRepository
    {
        private VetContext1 db;
        public VetRepository()
        {
            db = new VetContext1();
        }
        public Vets SaveVet(Vets VetToSave)
        {
            using (var db = new VetContext1())
            {
                db.Vets.Add(VetToSave);
                db.SaveChanges();
                return VetToSave;
            }
        }
 


        public bool UpdateVet(Vets vet)
        {
            var existingVet = db.Vets.Where(x => x.Id == vet.Id).Include(x => x.ContactInfo).FirstOrDefault();

            if (existingVet == null)
            {
                return false;
            }
            else
            {
                db.Entry(existingVet).CurrentValues.SetValues(vet);
                var Contacts = existingVet.ContactInfo;
                if (Contacts == null)
                {
                    existingVet.ContactInfo = new VetContactInfo()
                    {
                        EmailId = vet.ContactInfo.EmailId,
                        PhoneNum = vet.ContactInfo.PhoneNum,
                        ClinicAddress = vet.ContactInfo.ClinicAddress,
                    };
                }
                else if (Contacts.Id == vet.ContactInfo.Id)
                {
                    db.Entry(existingVet.ContactInfo).CurrentValues.SetValues(vet.ContactInfo);
                }
            }
            db.SaveChanges();
            return true;



        }

        public ICollection<Vets> GetAllVets()
        {

            using (var db = new VetContext1())
            {
                ICollection<Vets> vets = db.Vets.Include(a => a.VetSchedules).Include(a => a.ContactInfo).ToList();
                return vets;
            }
        }
        public Vets GetAllDetailsByVetId(int vetId)
        {
            using (var db = new VetContext1())
            {
                Vets vets = db.Vets

                 .Include(a => a.ContactInfo)
                 .Include(a => a.VetSchedules)
                  .Where(a => a.Id == vetId).First();
                return vets;
            }
        }
       
    }
}


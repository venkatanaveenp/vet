using Petzey.Vet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Repository.Interfaces
{
    public interface IVetRepository
    {
        ICollection<Vets> GetAllVets();
        Vets SaveVet(Vets VetToSave);
     bool UpdateVet(Vets vet);
        Vets GetAllDetailsByVetId(int vetId)
             ;
       


    }
}

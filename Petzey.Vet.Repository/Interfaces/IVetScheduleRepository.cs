using Petzey.Vet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Repository.Interfaces
{
    public interface IVetScheduleRepository
    {
        int EditVetschedule(VetSchedule vetSchedule);
        ICollection<VetSchedule> GetVetSchedule();
    }
}

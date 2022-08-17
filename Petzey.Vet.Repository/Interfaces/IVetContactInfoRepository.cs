using Petzey.Vet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Repository.Interfaces
{
   public interface IVetContactInfoRepository
    {
        int EditVetInfo(VetContactInfo vetContactdetails);
        ICollection<VetContactInfo> GetVetContactInfos();


    }
}

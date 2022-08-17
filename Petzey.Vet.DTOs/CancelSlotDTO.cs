using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.DTOs
{
    public  class CancelSlotDTO
    {


        public int VetId { get; set; }

        public int Id { get; set; }

        public bool IsBooked { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Model
{
    public class Vets
    {
        [Key]
        public int Id { get; set; }

        public int NPINum { get; set; }
        [MaxLength(30)]
        public string VetName { get; set; }

        [MaxLength(30)]
        public string Speciality { get; set; }

        public VetContactInfo ContactInfo { get; set; }
        public string VetsPicture { get; set; }
        public string Password { get; set; }

        public ICollection<VetSchedule> VetSchedules { get; set; }
       
    }
}

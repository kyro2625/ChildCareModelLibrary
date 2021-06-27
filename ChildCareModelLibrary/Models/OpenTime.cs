using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChildCareModelLibrary.Models
{
    public class OpenTime
    {
        public OpenTime()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int OpenTimeID { get; set; }
        public string SpecificTime { get; set; }

        [InverseProperty(nameof(Reservation.OpenTime))]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

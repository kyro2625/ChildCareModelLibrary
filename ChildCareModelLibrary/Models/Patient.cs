using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChildCareModelLibrary.Models
{
    public class Patient
    {
        public Patient()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public int Gender { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public string Birthday { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }


        [ForeignKey(nameof(CustomerID))]
        [InverseProperty("Patients")]
        public virtual Customer Customer { get; set; }

        [InverseProperty(nameof(Reservation.Patient))]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

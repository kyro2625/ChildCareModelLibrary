using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChildCareModelLibrary.Models
{
    public class Customer
    {
        public Customer()
        {
            Patients = new HashSet<Patient>();
            Reservations = new HashSet<Reservation>();
            Feedbacks = new HashSet<Feedback>();
        }

        public int CustomerID { get; set; }

        [InverseProperty(nameof(Patient.Customer))]
        public virtual ICollection<Patient> Patients { get; set; }

        [InverseProperty(nameof(Reservation.Customer))]
        public virtual ICollection<Reservation> Reservations { get; set; }

        [InverseProperty(nameof(Feedback.Customer))]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}

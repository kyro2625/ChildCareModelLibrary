using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChildCareModelLibrary.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Blogs = new HashSet<Blog>();
            Services = new HashSet<Service>();
            Reservations = new HashSet<Reservation>();
        }

        [Key]
        public int StaffID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        public string CitizenID { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public int IdentityID { get; set; }
        public int? SpecialtyID { get; set; }

        [ForeignKey(nameof(IdentityID))]
        [InverseProperty("Staffs")]
        public virtual Identity Identity { get; set; }

        [ForeignKey(nameof(SpecialtyID))]
        [InverseProperty("Staffs")]
        public virtual Specialty Specialty { get; set; }

        [InverseProperty(nameof(Blog.Staff))]
        public virtual ICollection<Blog> Blogs { get; set; }

        [InverseProperty(nameof(Service.Staff))]
        public virtual ICollection<Service> Services { get; set; }

        [InverseProperty(nameof(Reservation.Staff))]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

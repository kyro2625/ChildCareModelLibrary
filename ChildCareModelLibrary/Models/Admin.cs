using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChildCareModelLibrary.Models
{
    public partial class Admin
    {
        public Admin() { }

        [Key]
        public int AdminID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        public string CitizenID { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        [Required]
        public int IdentityID { get; set; }

        [ForeignKey(nameof(IdentityID))]
        [InverseProperty("Admins")]
        public virtual Identity Identity { get; set; }
    }
}

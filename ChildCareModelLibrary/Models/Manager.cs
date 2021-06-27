using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChildCareModelLibrary.Models
{
    public partial class Manager
    {
        public Manager() { }

        [Key]
        public int ManagerID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        public string CitizenID { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public int IdentityID { get; set; }

        [ForeignKey(nameof(IdentityID))]
        [InverseProperty("Managers")]
        public virtual Identity Identity { get; set; }
    }
}

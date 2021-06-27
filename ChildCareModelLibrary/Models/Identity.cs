using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChildCareModelLibrary.Models
{
    public partial class Identity
    {
        public Identity()
        {
            Admins = new HashSet<Admin>();
            Managers = new HashSet<Manager>();
            Staffs = new HashSet<Staff>();
            Customers = new HashSet<Customer>();

        }

        [Key]
        public int IndentityID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }


        [InverseProperty(nameof(Admin.Identity))]
        public virtual ICollection<Admin> Admins { get; set; }

        [InverseProperty(nameof(Manager.Identity))]
        public virtual ICollection<Manager> Managers { get; set; }

        [InverseProperty(nameof(Staff.Identity))]
        public virtual ICollection<Staff> Staffs { get; set; }

        [InverseProperty(nameof(Customer.Identity))]
        public virtual ICollection<Customer> Customers { get; set; }

    }
}

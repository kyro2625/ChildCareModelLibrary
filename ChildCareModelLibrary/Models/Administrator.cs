using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChildCareModelLibrary.Models
{
    public partial class Administrator
    {
        public Administrator() { }

        [Key]
        public int AdminID { get; set; }
        
        
    }
}

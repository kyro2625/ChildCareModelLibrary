﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChildCareModelLibrary.Models
{
    public partial class Manager
    {
        public Manager() { }

        [Key]
        public int ManagerID { get; set; }
        
    }
}

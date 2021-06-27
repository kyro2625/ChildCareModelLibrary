﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChildCareModelLibrary.Models
{
    public class MedicalExamination
    {
        public MedicalExamination() { }

        [Key]
        public int ExaminationID { get; set; }
        public int? ReservationID { get; set; }
        public int? ServiceID { get; set; }
        public string Prescription { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }

        [ForeignKey(nameof(ReservationID))]
        [InverseProperty("MedicalExaminations")]
        public virtual Reservation Reservation { get; set; }

        [ForeignKey(nameof(ServiceID))]
        [InverseProperty("MedicalExaminations")]
        public virtual Service Service { get; set; }
    }
}

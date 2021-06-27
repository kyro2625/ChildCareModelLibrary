using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChildCareModelLibrary.Models
{
    public class Service
    {
        public Service()
        {
            Feedbacks = new HashSet<Feedback>();
            MedicalExaminations = new HashSet<MedicalExamination>();
        }

        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public int? SpecialtyID { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int? StatusID { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public int? StaffID { get; set; }

        [ForeignKey(nameof(StaffID))]
        [InverseProperty("Services")]
        public virtual Staff Staff { get; set; }

        [ForeignKey(nameof(SpecialtyID))]
        [InverseProperty("Services")]
        public virtual Specialty Specialty { get; set; }

        [ForeignKey(nameof(StatusID))]
        [InverseProperty("Services")]
        public virtual Status Status { get; set; }

        [InverseProperty(nameof(Feedback.Service))]
        public virtual ICollection<Feedback> Feedbacks { get; set; }

        [InverseProperty(nameof(MedicalExamination.Service))]
        public virtual ICollection<MedicalExamination> MedicalExaminations { get; set; }
    }
}

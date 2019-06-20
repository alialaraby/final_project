namespace FinalProject.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("instructor")]
    public partial class instructor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public instructor()
        {
            courses = new HashSet<course>();
            instructor_phone = new HashSet<instructor_phone>();
            qualifications = new HashSet<qualification>();
        }

        [Key]
        public int instructor_id { get; set; }

        [Required]
        public string instructor_name { get; set; }

        public string Current_JobTitle { get; set; }

        public string NameOf_ItsUnit { get; set; }

        public string TrainningTopic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<course> courses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<instructor_phone> instructor_phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<qualification> qualifications { get; set; }
    }
}

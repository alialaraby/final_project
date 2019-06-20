namespace FinalProject.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("qualification")]
    public partial class qualification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public qualification()
        {
            user_data = new HashSet<user_data>();
            instructors = new HashSet<instructor>();
        }

        [Key]
        public int qualification_id { get; set; }

        public string qualification_name { get; set; }

        public DateTime? qualification_date { get; set; }

        [StringLength(50)]
        public string organization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_data> user_data { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<instructor> instructors { get; set; }
    }
}

namespace FinalProject.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("parenter")]
    public partial class parenter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public parenter()
        {
            parenters_phones = new HashSet<parenters_phones>();
        }

        [Key]
        public int parenter_id { get; set; }

        public string parenter_name { get; set; }

        public string image { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<parenters_phones> parenters_phones { get; set; }
    }
}

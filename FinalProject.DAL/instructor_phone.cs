namespace FinalProject.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class instructor_phone
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int instructor_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string phone { get; set; }

        public virtual instructor instructor { get; set; }
    }
}

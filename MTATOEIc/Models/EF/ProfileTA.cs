namespace MTATOEIc.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProfileTA")]
    public partial class ProfileTA
    {
        [Key]
        [StringLength(50)]
        public string Pro_ID { get; set; }

        [StringLength(50)]
        public string Pro_FullName { get; set; }

        [StringLength(150)]
        public string Pro_Address { get; set; }

        [StringLength(50)]
        public string Pro_Phone { get; set; }

        [StringLength(250)]
        public string Pro_Email { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Pro_CreateDate { get; set; }

        public string Pro_Intro { get; set; }

        public virtual Account Account { get; set; }
    }
}

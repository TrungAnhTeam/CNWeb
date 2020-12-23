namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Unit")]
    public partial class Unit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Unit_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Unit_Name { get; set; }

        [Required]
        public string Unit_Content { get; set; }

        public bool? IsActive { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Unit_CreateDate { get; set; }

        public int? Lesson_ID_FK { get; set; }

        [StringLength(50)]
        public string Account_ID_FK { get; set; }

        public virtual Account Account { get; set; }

        public virtual Lesson Lesson { get; set; }
    }
}

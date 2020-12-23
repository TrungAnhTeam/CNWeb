namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            Suggests = new HashSet<Suggest>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ques_ID { get; set; }

        [StringLength(255)]
        public string Ques_Tittle { get; set; }

        [Required]
        public string Ques_Content { get; set; }

        public bool Approve { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ques_CreateDate { get; set; }

        public int? Type_ID_FK { get; set; }

        public int? Lesson_ID_FK { get; set; }

        [StringLength(50)]
        public string Username_FK { get; set; }

        public string Ques_Description { get; set; }

        public virtual Account Account { get; set; }

        public virtual Lesson Lesson { get; set; }

        public virtual TypeTA TypeTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suggest> Suggests { get; set; }
    }
}

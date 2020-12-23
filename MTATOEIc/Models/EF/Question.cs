namespace MTATOEIc.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ques_ID { get; set; }

        [Required]
        public string Ques_Content { get; set; }

        public bool Approve { get; set; }

        public bool IsActive { get; set; }

        public int? Unit_ID_FK { get; set; }

        [StringLength(50)]
        public string Username_FK { get; set; }

        [StringLength(100)]
        public string Answer_1 { get; set; }

        [StringLength(100)]
        public string Answer_2 { get; set; }

        [StringLength(100)]
        public string Answer_3 { get; set; }

        [StringLength(100)]
        public string Answer_4 { get; set; }

        public int? Answer { get; set; }

        [StringLength(500)]
        public string Sugget_conten { get; set; }

        public virtual Account Account { get; set; }

        public virtual Unit Unit { get; set; }
    }
}

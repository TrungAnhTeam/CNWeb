namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Suggest")]
    public partial class Suggest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sug_ID { get; set; }

        [Required]
        public string Sug_Content { get; set; }

        [Required]
        [StringLength(50)]
        public string Sug_Answer { get; set; }

        public int? Ques_ID_FK { get; set; }

        [StringLength(50)]
        public string Sug_Position { get; set; }

        public virtual Question Question { get; set; }
    }
}

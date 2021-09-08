namespace SG_MKP_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USUARIO")]
    public partial class USUARIO
    {
        [Key]
        public int USU_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string USU_USUARIO { get; set; }

        [Required]
        [StringLength(20)]
        public string USU_SENHA { get; set; }
    }
}

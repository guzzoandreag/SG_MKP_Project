namespace SG_MKP_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUTO")]
    public partial class PRODUTO
    {
        [Key]
        public int PRO_CODIGO { get; set; }

        [Required]
        [StringLength(150)]
        public string PRO_DESCRICAO { get; set; }

        [Required]
        [StringLength(50)]
        public string PRO_CATEGORIA { get; set; }

        public decimal PRO_VALORVENDA { get; set; }

        [Column(TypeName = "image")]
        public byte[] PRO_IMAGEM_1 { get; set; }

        [Column(TypeName = "image")]
        public byte[] PRO_IMAGEM_2 { get; set; }

        [Column(TypeName = "image")]
        public byte[] PRO_IMAGEM_3 { get; set; }

        [Required]
        [StringLength(50)]
        public string PRO_CONDICAOPRODUTO { get; set; }

        public double PRO_QUANTIDADEDISPONIVEL { get; set; }
    }
}

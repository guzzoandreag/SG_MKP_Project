using System;
using System.Collections.Generic;
using System.Text;

namespace SG_MKP_App.Model
{
    class PRODUTO
    {
        public int PRO_CODIGO { get; set; }
        public string PRO_DESCRICAO { get; set; }
        public string PRO_CATEGORIA { get; set; }
        public double PRO_VALORVENDA { get; set; }
        //public byte[] PRO_IMAGEM { get; set; }
        public byte[] PRO_IMAGEM_1 { get; set; }
        public byte[] PRO_IMAGEM_2 { get; set; }
        public byte[] PRO_IMAGEM_3 { get; set; }
        //public byte[] PRO_IMAGEM_4 { get; set; }
        //public byte[] PRO_IMAGEM_5 { get; set; }
        public string PRO_CONDICAOPRODUTO { get; set; }
        public float PRO_QUANTIDADEDISPONIVEL { get; set; }

    }
}

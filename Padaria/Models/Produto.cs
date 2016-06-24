using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Padaria.Models
{
    public class Produto
    {
        [Key]
        public int idProduto { get; set; }

        [Required(ErrorMessage ="Nome Produto é Obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Informar Quantidade em Estoque é Obrigatorio")]
        public int QtdEstoque { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Padaria.Models
{
    public class Endereco : Cliente
    {
        [Key]
        public int idEndereco { get; set; }

        [Required(ErrorMessage ="Nome da Rua é Obrigatorio")]
        [StringLength(100 , ErrorMessage ="Maximo de 100 Caracteres")]
        public string Rua { get; set; }

        [Required(ErrorMessage ="Numero é Obrigatorio")]
        public int Numero { get; set; }

        [Required]
        public string Bairro { get; set; }


        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Complemento { get; set; }

        

    }
}
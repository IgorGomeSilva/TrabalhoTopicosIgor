using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Padaria.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }

        [Required(ErrorMessage ="Nome é Obrigatorio")]
        [StringLength(60 ,ErrorMessage ="Maximo de 100 Caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="CPF é Obrigatorio")]
        public long Cpf { get; set; }


        [Required]
        public string Email { get; set; }


        
    }
}
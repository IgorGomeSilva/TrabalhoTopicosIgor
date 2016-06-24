using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Padaria.Models
{
    public class UF
    {
        [Key]
        public char idUF { get; set; }

        [Required(ErrorMessage ="Descrição é Obrigatorio")]
        [StringLength(30 , ErrorMessage ="Maximo de 30 Caracteres")]
        public string Descricao { get; set; }
    }
}
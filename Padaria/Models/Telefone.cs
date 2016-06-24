using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Padaria.Models
{
    public class Telefone : TipoTelefone
    {
        [Key]
        public int idTelefone { get; set; }


        [Required]
        public int Sequencia { get; set; }
        
        [Required]
        public string NumTelefone { get; set; }



        
    }
}
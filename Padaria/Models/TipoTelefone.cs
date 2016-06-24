using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Padaria.Models
{
    public class TipoTelefone
    {
        [Key]
        public int idTipoTelefone { get; set; }

        [Required]
        public string Descricao { get; set; }

    }
}
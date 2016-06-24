using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Padaria.Models
{
    public class Compra : Cliente
    {
        [Key]
        public int idCompra { get; set; }

        [Required]
        public DateTime DataCompra { get; set; }

    }
}
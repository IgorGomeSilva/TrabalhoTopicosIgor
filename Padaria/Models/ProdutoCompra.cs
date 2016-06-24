using System.ComponentModel.DataAnnotations;

namespace Padaria.Models
{
    public class ProdutoCompra : Produto
    {
        [Key]
        public int idItensCompra { get; set; }

        [Required]
        public int QtdItens { get; set; }

        [Required]
        public decimal ValorUnitario { get; set; }
    }
}
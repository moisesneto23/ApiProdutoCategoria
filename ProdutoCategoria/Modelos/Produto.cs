using ProdutoCategoria.Modelos;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdutoCategoria.Controllers
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required][MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(200)]
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        [Required]
        [MaxLength(500)]
        public string ImgUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime  Caadastro { get; set; }
        public virtual Categoria? Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}

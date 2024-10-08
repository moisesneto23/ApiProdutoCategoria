﻿using ProdutoCategoria.Controllers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdutoCategoria.Modelos
{
    [Table("Categorias")]
    public class Categoria
    {

        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        [Key]
        public int CategoriaId { get; set; }
        [Required][MaxLength(80)]
        public string Nome { get; set; }
        [Required][MaxLength(300)]
        public string ImgUrl { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}

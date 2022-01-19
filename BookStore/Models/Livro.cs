
using System;

namespace BookStore.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ISBN { get; set; }
        public DateTime DataLancamento { get; set; }


        //Relacionamento com CATEGORIA
        public int CategoriaId { get; set; }
        public Categoria categoria { get; set; }


    }
}

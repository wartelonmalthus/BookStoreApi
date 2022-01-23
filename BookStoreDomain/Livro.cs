
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStoreDomain
{
    public class Livro
    {
        public Livro()
        {
            this.Autores = new List<Autor>();


        }
       
        public int Id { get; set; }

        public string Nome { get; set; }

        public string ISBN { get; set; }

        public DateTime DataLancamento { get; set; }


        //Relacionamento com CATEGORIA
        public int CategoriaId { get; set; }
        public Categoria categoria { get; set; }



        //Relacionamento com AUTOR
        public ICollection<Autor> Autores { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreDomain
{
    public class Autor
    {
        public Autor()
        {
            this.Livros = new List<Livro>();

        }
      
        public int Id { get; set; }
        public string Nome { get; set; }


        //Relacionamento com LIVRO 
        public ICollection<Livro> Livros { get; set; }

    }   
}

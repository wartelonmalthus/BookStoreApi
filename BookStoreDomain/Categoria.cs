
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreDomain
{
    public class Categoria
    {
        public Categoria()
        {
            this.Livros = new List<Livro>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30,MinimumLength =3, ErrorMessage = "Campo invalido")]
        public string Nome { get; set; }

        //Relacionamento com Livro
        public ICollection<Livro> Livros { get; set; }
    }
}

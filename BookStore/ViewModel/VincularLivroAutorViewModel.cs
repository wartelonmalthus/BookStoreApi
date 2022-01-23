using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.ViewModel
{
    public class VincularLivroAutorViewModel
    {
        [Required(ErrorMessage ="*")]
        public int LivroId { get; set; }

        [Required(ErrorMessage = "*")]
        public int AutorId { get; set; }
    }
}

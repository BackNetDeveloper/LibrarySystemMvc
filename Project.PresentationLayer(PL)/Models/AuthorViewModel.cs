using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.PresentationLayer_PL_.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Author Name is Required")]      // ErrorMessages Will Appear In UI
        [MinLength(3, ErrorMessage = "MinLength Is 3 Charachters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Author Name is Required")]      // ErrorMessages Will Appear In UI
        [MinLength(3, ErrorMessage = "MinLength Is 3 Charachters")]
        public string Address { get; set; }

        public ICollection<BookViewModel> Books { get; set; }

    }
}

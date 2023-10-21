using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer_DAL_.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="MaxLength 50 charachter")]
        [MinLength(5,ErrorMessage ="MinLength 5 charachter")]
        public string Title { get; set; }
        [Display(Name = "Date Of Bublish")]
        public DateTime DateOfBublish { get; set; } = DateTime.Now;
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

    }
}

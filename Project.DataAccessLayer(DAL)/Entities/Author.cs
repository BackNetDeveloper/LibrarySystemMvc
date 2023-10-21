using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer_DAL_.Entities
{
    public class Author
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Department Name is Required")]      // ErrorMessages Will Appear In UI
        [MinLength(3,ErrorMessage = "MinLength Is 3 Charachters")]   
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Book>  Books { get; set; } = new HashSet<Book>();

    }
}

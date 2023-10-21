using Project.DataAccessLayer_DAL_.Entities;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Http;

namespace Project.PresentationLayer_PL_.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "MaxLength 50 charachter")]
        [MinLength(5, ErrorMessage = "MinLength 5 charachter")]
        public string Title { get; set; }
        [Display(Name = "Date Of Bublish")]
        public DateTime DateOfBublish { get; set; } = DateTime.Now;
        public  int AuthorId { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.ChangeTracking;
using Project.BussinessLogicLayer_BLL_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessLogicLayer_BLL_.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IAuthorRepository authorRepository, IBookRepository bookRepository)
        {
            AuthorRepository = authorRepository;
            BookRepository = bookRepository;
        }

        public IAuthorRepository AuthorRepository { get; set; }
        public IBookRepository BookRepository { get ; set ; }
    }
}

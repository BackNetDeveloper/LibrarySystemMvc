using Microsoft.EntityFrameworkCore;
using Project.BussinessLogicLayer_BLL_.Interfaces;
using Project.DataAccessLayer_DAL_.Contexts;
using Project.DataAccessLayer_DAL_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessLogicLayer_BLL_.Repositories
{
    public class AuthorRepository : GenericRepository<Author> , IAuthorRepository
    {
        private readonly LibraryDbContext context;

        public AuthorRepository(LibraryDbContext context):base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Book>> GetBooksByAuthorId(int Id)
        {
            return await context.Books.Where(B => B.AuthorId == Id).ToListAsync();
        }
    }
}

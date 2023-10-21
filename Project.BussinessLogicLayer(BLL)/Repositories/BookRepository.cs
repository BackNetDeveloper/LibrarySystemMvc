using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class BookRepository : GenericRepository<Book>,IBookRepository
    {
        private readonly LibraryDbContext context;

        public BookRepository(LibraryDbContext context):base(context)
        {
            this.context = context;
        }

        public async Task<string> GetAutherByBookId(int? Id)
        {
            var employee = await context.Books.Where(E => E.Id == Id).Include(E => E.Author).FirstOrDefaultAsync();
            var AutherName = employee.Author.Name;
            return AutherName;
        }

    }
}

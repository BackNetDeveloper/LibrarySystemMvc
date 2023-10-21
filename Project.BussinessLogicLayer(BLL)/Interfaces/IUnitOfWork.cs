using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessLogicLayer_BLL_.Interfaces
{
    public interface IUnitOfWork
    {
        public  IAuthorRepository AuthorRepository { get; set; }
        public  IBookRepository BookRepository { get; set; }
    }
}

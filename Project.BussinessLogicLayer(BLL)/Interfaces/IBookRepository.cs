using Project.DataAccessLayer_DAL_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessLogicLayer_BLL_.Interfaces
{
    public interface IBookRepository: IGenericRepository<Book>
    {
        Task<string> GetAutherByBookId(int? Id);
    }
}

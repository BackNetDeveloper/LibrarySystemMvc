using AutoMapper;
using Project.DataAccessLayer_DAL_.Entities;
using Project.PresentationLayer_PL_.Models;

namespace Project.PresentationLayer_PL_.Mappers
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author,AuthorViewModel>();
            CreateMap<AuthorViewModel, Author>();

            //// Or Use The Simple Way
            //CreateMap<Department, DepartmentViewModel>().ReverseMap();
        }
    }
}

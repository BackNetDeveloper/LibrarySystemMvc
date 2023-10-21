using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.BussinessLogicLayer_BLL_.Interfaces;
using Project.BussinessLogicLayer_BLL_.Repositories;
using Project.DataAccessLayer_DAL_.Entities;
using Project.PresentationLayer_PL_.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project.PresentationLayer_PL_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger , IUnitOfWork unitOfWork,IMapper mapper)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var Authors = await _unitOfWork.AuthorRepository.GetAll();
            var mappedauthors = _mapper.Map<IEnumerable<AuthorViewModel>>(Authors);
            return View(mappedauthors);
        }

        public async Task<IActionResult> ShowData(int id ,string name)
        {
            var books = await _unitOfWork.AuthorRepository.GetBooksByAuthorId(id);
            ViewBag.AuthorName = name;
            var mappedBooks = _mapper.Map<IEnumerable<BookViewModel>>(books);
            return View(mappedBooks);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BussinessLogicLayer_BLL_.Interfaces;
using Project.DataAccessLayer_DAL_.Entities;
using Project.PresentationLayer_PL_.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Project.PresentationLayer_PL_.Controllers
{
    [Authorize(Roles = "admin")]
    public class BookController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public BookController(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Book> Books = await unitOfWork.BookRepository.GetAll();
            
            var MappedBooks = mapper.Map<IEnumerable<BookViewModel>>(Books);
            return View(MappedBooks);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.authors =await unitOfWork.AuthorRepository.GetAll();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BookViewModel viewmodel)
        {
            if (ModelState.IsValid)
            {
                var mappedbook =  mapper.Map<Book>(viewmodel);
                await unitOfWork.BookRepository.Add(mappedbook);
                ViewBag.authors = await unitOfWork.AuthorRepository.GetAll();
                return RedirectToAction("Index");
            }
            return View(viewmodel);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id is null)
                return NotFound();
            Book book = await unitOfWork.BookRepository.Get(id);
            var AuthorName = await unitOfWork.BookRepository.GetAutherByBookId(id);
            book.Author.Name=AuthorName;
            var mappedbook = mapper.Map<BookViewModel>(book);
            if (book is null)
                return NotFound();
            return View(mappedbook);
        }
        public async Task<IActionResult> Update( int? id)
        {
            if (id is null)
                return NotFound();
            ViewBag.authors = await unitOfWork.AuthorRepository.GetAll();
            var book = await unitOfWork.BookRepository.Get(id);
            var mappedbook = mapper.Map<BookViewModel>(book);
            if (book is null)
                return NotFound();
           
            return View(mappedbook);
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromRoute]int? id, BookViewModel viewmodel)
        {
            if (id != viewmodel.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    var mappedbook = mapper.Map<Book>(viewmodel);
                    await unitOfWork.BookRepository.Update(mappedbook);
                    ViewBag.authors = await unitOfWork.AuthorRepository.GetAll();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(viewmodel);
                }

            }
            return View(viewmodel);
        }
       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return NotFound();
            var book = await unitOfWork.BookRepository.Get(id);
            if (book is null)
                return NotFound();
            await unitOfWork.BookRepository.Delete(book);
            return RedirectToAction("Index");
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BussinessLogicLayer_BLL_.Interfaces;
using Project.BussinessLogicLayer_BLL_.Repositories;
using Project.DataAccessLayer_DAL_.Entities;
using Project.PresentationLayer_PL_.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.PresentationLayer_PL_.Controllers
{
    [Authorize(Roles = "admin")]
    public class AuthorController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public AuthorController(IUnitOfWork unitOfWork ,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var Authors =await unitOfWork.AuthorRepository.GetAll();
            var mappedauthor = mapper.Map<IEnumerable<AuthorViewModel>>(Authors);
            return View(mappedauthor);
        }
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AuthorViewModel ViewModel )
        {
            if (ModelState.IsValid)
            {
                var mappedauthor = mapper.Map<Author>(ViewModel);
                await unitOfWork.AuthorRepository.Add(mappedauthor);
                return RedirectToAction("Index");
            }
            return View(ViewModel);
        }
        public async Task<IActionResult>  Details(int?id)
        {
            if (id is null)
                return NotFound();
            var author = await unitOfWork.AuthorRepository.Get(id);
            var mappedauthor = mapper.Map<AuthorViewModel>(author);
            if (author is null)
                return NotFound();
            return View(mappedauthor);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id is null)
                return NotFound();
            var author = await unitOfWork.AuthorRepository.Get(id);
            var mappedauthor = mapper.Map<AuthorViewModel>(author);
            if (author is null)
                return NotFound();
            return View(mappedauthor);
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromRoute] int? id, AuthorViewModel ViewModel)
        {
            if (id != ViewModel.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    var mappedauthor = mapper.Map<Author>(ViewModel);
                   await unitOfWork.AuthorRepository.Update(mappedauthor);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(ViewModel);
                }

            }
            return View(ViewModel);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return NotFound();
            var author = await unitOfWork.AuthorRepository.Get(id);
            var mappedauthor = mapper.Map<AuthorViewModel>(author);
            if (author is null)
                return NotFound();
            return View(mappedauthor);
        }
        [HttpPost]
        public async Task<IActionResult> Delete([FromRoute]int? id, AuthorViewModel ViewModel)
        {
            if (id != ViewModel.Id)
                return NotFound();

            try
            {
                var mappedauthor = mapper.Map<Author>(ViewModel);
                await unitOfWork.AuthorRepository.Delete(mappedauthor);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(ViewModel);
            }

        }

        
        #region Simple way To Delete Without Veiw
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id is null)
        //        return NotFound();
        //    var author = await authorRepository.Get(id);
        //    if (author is null)
        //        return NotFound();
        //    await authorRepository.Delete(author);
        //    return RedirectToAction("Index");
        //}
        #endregion
    }
}

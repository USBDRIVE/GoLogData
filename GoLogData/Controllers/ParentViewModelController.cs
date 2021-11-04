﻿using GoLogData.Data;
using GoLogData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoLogData.Controllers
{
    public class ParentViewModelController : Controller
    {

        private readonly ApplicationDbContext _context;
        public ParentViewModelController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: HomeController1
        public async Task<IActionResult> Index()
        {
            return View(await _context.ParentViewModels.ToListAsync());
            // return View();
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ParentViewModel parentViewModel)
        {
            if (ModelState.IsValid)
            {
                parentViewModel.ParentViewModelId = Guid.NewGuid();
                parentViewModel.Databook = new Databooks()
                {
                   
                    Title = parentViewModel.Databook.Title,
                    Color = parentViewModel.Databook.Color,
                    Description = parentViewModel.Databook.Description
                };
                
                _context.Add(parentViewModel.Databook);
                _context.Add(parentViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parentViewModel);
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
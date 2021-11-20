using GoLogData.Data;
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
                    MultipleModels = false,
                    Title = parentViewModel.Databook.Title,
                    Color = parentViewModel.Databook.Color,
                    Description = parentViewModel.Databook.Description
                };
                //every databook to have a default basic datamodel
                parentViewModel.DataModel = new DataModel()
                {
                    Databooks = parentViewModel.Databook,
                    Title = "default",
                    Label = "default label",
                    Description = "This is the default data model",
                    ModelId = Guid.NewGuid()

                };
                
                //_context.Add(parentViewModel.Databook);
                //_context.Add(parentViewModel.DataModel);
                _context.Add(parentViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Databooks");
            }
            return View(parentViewModel);
        }

        // GET: HomeController1/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            
           

            await using (var context = _context)
            {
                var query = from dm in context.DataModels
                            where dm.Databooks.Id == id 
                            select dm;
                //get DataModel where datamodel.DatabookId = id 
                List<DataModel> answer = query.ToList<DataModel>();
                
                ViewData["dataModels"] = answer;

            }
            

            
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

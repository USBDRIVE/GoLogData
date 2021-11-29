using GoLogData.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GoLogData.Models;

namespace GoLogData.Controllers
{
    public class DataModelController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DataModelController(ApplicationDbContext context)
        {
            _context = context;
        }



        // GET: DataModelController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DataModelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult AddModel(Guid id)
        {
            return View();
        }
        public ActionResult AddData(Guid id)
        {
            return View();
        }
        
       public async Task<IActionResult> CreateDataCell(string input, Guid modelId) 
       {
            //what do we need to create datacell? input and maybe the datamodelId
            if (ModelState.IsValid)
            {
                
                await using(var context = _context)
                {
                    //DataModel query = (DataModel)(from dm in context.DataModels
                    //                              where dm.ModelId == modelId
                    //                              select dm);
                    DataModel x = context
                        .ParentViewModels
                        .Where(u=>u.DataModel.ModelId == modelId)
                        .Select(u => u.DataModel)
                        .SingleOrDefault();
                    var newDataCell = new Datacell()
                    {
                        input = input,
                        Id = Guid.NewGuid(),
                        //get data from database where datamodle = modelId
                        DataModel = x // making issues
                    };
                    context.Add(newDataCell);
                    await context.SaveChangesAsync();
                    return RedirectToAction("Index", "DataBooks");
                }

            }
            return View();
       }

        // GET: DataModelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DataModelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: DataModelController/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: DataModelController/Edit/5
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

        // GET: DataModelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DataModelController/Delete/5
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

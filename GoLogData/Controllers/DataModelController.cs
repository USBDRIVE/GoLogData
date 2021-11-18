using GoLogData.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult Add(Guid id)
        {
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

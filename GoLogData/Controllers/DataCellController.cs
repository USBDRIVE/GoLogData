using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoLogData.Controllers
{
    public class DataCellController : Controller
    {
        // GET: DataCellController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DataCellController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DataCellController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DataCellController/Create
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

        // GET: DataCellController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DataCellController/Edit/5
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

        // GET: DataCellController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DataCellController/Delete/5
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

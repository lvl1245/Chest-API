using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chest_API.Controllers
{
    public class ChestTypeController : Controller
    {
        // GET: ChestTypeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChestTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChestTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChestTypeController/Create
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

        // GET: ChestTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChestTypeController/Edit/5
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

        // GET: ChestTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChestTypeController/Delete/5
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

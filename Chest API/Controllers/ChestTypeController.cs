using Chest.Domain;
using Chest.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chest_API.Controllers
{
    public class ChestTypeController : Controller
    {
        readonly ChestDbContext chestDbContext;
        public ChestTypeController(ChestDbContext context)
        {
            chestDbContext = context;
        }
        // GET: ChestTypeController
        public ActionResult Index()
        {
            ViewBag.ChestCount = chestDbContext.chestTypes.Count();
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

        [HttpPost]
        public async Task<IActionResult> Create(ChestType chestType)
        {
            chestDbContext.chestTypes.Add(chestType);
            await chestDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
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

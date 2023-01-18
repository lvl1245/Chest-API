using Chest.Domain;
using Chest.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web;

namespace Chest_API.Controllers
{
    public class ChestController : Controller
    {
       
        readonly ChestDbContext chestDbContext;
        // GET: ChestController

        public ChestController(ChestDbContext context)
        {
            chestDbContext = context;
        }
        public async Task<IActionResult> Index()
        {
            //List<int> ints = new List<int>();   
            //foreach (var item in chestDbContext.Chests.ToList())
            //{
            //    if (item.StuffCollection != null)
            //    {
            //        ints.Add(item.StuffCollection.Count());
            //    }                
            //}
            return View(await chestDbContext.Chests.ToListAsync());
        }

        // GET: ChestController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new NotFoundResult();  
            }
            Chest.Domain.Chest chest = chestDbContext.Chests.Find(id);
            if (chest == null)
            {
                return new NotFoundResult();
            }
            chest.StuffCollection = chestDbContext.Stuffs.Where(m => m.ChestId == chest.Id).ToList();
            ViewBag.StuffCollection = chest.StuffCollection;
            return View(chest);
        }

        // GET: ChestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChestController/Create
        [HttpPost]
        public async Task<IActionResult> Create(Chest.Domain.Chest chest)
        {
            chest.CurrentSpase = chest.Size;
          
            chestDbContext.Chests.Add(chest);
            await chestDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: ChestController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new NotFoundResult();
            }
            Chest.Domain.Chest chest = chestDbContext.Chests.Find(id);
            if (chest == null)
            {
                return new NotFoundResult();
            }



            return View(chest);
        }

        // POST: ChestController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Chest.Domain.Chest chest)
        {
            chestDbContext.Update(chest);
            await chestDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: ChestController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var TmpChest = await chestDbContext.Chests
      .FirstOrDefaultAsync(m => m.Id == id);
            if (TmpChest == null)
            {
                return NotFound();
            }

            return View(TmpChest);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (chestDbContext.Chests == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var chest = await chestDbContext.Chests.FindAsync(id);
            chestDbContext.Chests.Remove(chest);
            await chestDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

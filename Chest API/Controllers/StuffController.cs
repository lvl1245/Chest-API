using Microsoft.AspNetCore.Mvc;
using Chest.Persistence;
using Chest.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Chest.Domain;
namespace Chest_API.Controllers
{
    public class StuffController : Controller
    {
       
        readonly ChestDbContext chestDbContext;
        public StuffController(ChestDbContext context)
        {
            chestDbContext = context;
        }
        public ActionResult Index()
        {
            var stuffs = chestDbContext.Stuffs.Include(p => p.Chest);
            return View(stuffs.ToList());
        }
        public ActionResult Create(int ChestId)
        {
            ViewBag.ChestId = ChestId;
           
            return View();
        }

        // POST: ChestController/Create
        [HttpPost]
        public async Task<IActionResult> Create(Chest.Domain.Stuff stuff)
        {
            Stuff tmpStuff = stuff;
            tmpStuff.Chest = chestDbContext.Chests.Find(tmpStuff.ChestId);
            if (tmpStuff.Chest.CurrentSpase > tmpStuff.Size && 0 < tmpStuff.Size)
            {
                tmpStuff.Chest.CountOfStuff += 1;
                tmpStuff.Chest.CurrentSpase -= tmpStuff.Size;
              
                chestDbContext.Stuffs.Add(tmpStuff);
                await chestDbContext.SaveChangesAsync(); 
                return RedirectToAction("Index");
            }
            else
            {
                return Problem("Stuff size is too big >:C ");
            }

           
        }
    }
}

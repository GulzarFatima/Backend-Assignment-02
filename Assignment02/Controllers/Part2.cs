using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    public class Part2 : Controller
    {
        // GET: Part2
        public ActionResult Index()
        {
            return View();
        }

        // GET: Part2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Part2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Part2/Create
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

        // GET: Part2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Part2/Edit/5
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

        // GET: Part2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Part2/Delete/5
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

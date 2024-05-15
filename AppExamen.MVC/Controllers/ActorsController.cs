using ConsumeAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppExamen.Entidades;

namespace AppExamen.MVC.Controllers
{
    public class ActoresController : Controller
    {
        private string urlApi;

        public ActoresController(IConfiguration configuration)
        {
            urlApi = configuration.GetValue("ApiUrlBase", "").ToString() + "/Actors";
        }
        // GET: ActoresController
        public ActionResult Index()
        {
            var data = Crud<Actor>.Read(urlApi);
            return View(data);
        }

        // GET: ActoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ActoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActoresController/Create
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

        // GET: ActoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ActoresController/Edit/5
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

        // GET: ActoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ActoresController/Delete/5
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

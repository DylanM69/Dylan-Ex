using ConsumeAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppExamen.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppExamen.MVC.Controllers
{
    public class PeliculasController : Controller
    {

        private string urlApi;

        public PeliculasController(IConfiguration configuration)
        {
            urlApi = configuration.GetValue("ApiUrlBase", "").ToString() + "/Peliculas";
        }
        // GET: PeliculasController
        public ActionResult Index()
        {
            var data = Crud<Pelicula>.Read(urlApi);
            return View(data);
        }

        // GET: PeliculasController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Pelicula>.Read_ById(urlApi, id);
            return View(data);

        }

        // GET: PeliculasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeliculasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pelicula data)
        {
            try
            {
                var newData = Crud<Pelicula>.Create(urlApi, data);

                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: PeliculasController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Pelicula>.Read_ById(urlApi, id);
            return View(data);
            
        }

        // POST: PeliculasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Pelicula data)
        {
            try
            {
                Crud<Pelicula>.Update(urlApi, id, data);
                return RedirectToAction(nameof(Index));
             
            }
            catch
            {
                return View(data);
            }
        }

        // GET: PeliculasController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Pelicula>.Read_ById(urlApi, id);
            return View(data);
           
        }

        // POST: PeliculasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Pelicula data)
        {
            try
            {
                var datos = Crud<Pelicula>.Delete(urlApi, id);
                return View(data);

            }
            catch
            {
                return View(data);
            }
        }
    }
}

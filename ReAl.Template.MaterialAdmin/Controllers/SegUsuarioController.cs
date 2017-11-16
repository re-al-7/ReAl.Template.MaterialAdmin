using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReAl.Template.MaterialAdmin.Dal.Entidades;

namespace ReAl.Template.MaterialAdmin.Controllers
{
    public class SegUsuarioController : BaseController
    {
        // GET: SegUsuario
        public ActionResult Index()
        {
            ViewBag.ListApp = this.getAplicaciones();
            ViewBag.ListPages = this.getPages();
            ViewData["Usuario"] = this.getUserName();

            List<EntSegUsuario> lista = new List<EntSegUsuario>();

            for (int i = 0; i < 500; i++)
            {
                var obj = new EntSegUsuario();
                obj.id_usuario = i;
                obj.login = "login " + i;
                obj.nombre = "nombre " + i;
                obj.paterno = "paterno " + i;
                lista.Add(obj);
            }
            return View(lista.ToList());
        }

        // GET: SegUsuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SegUsuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SegUsuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SegUsuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SegUsuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SegUsuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SegUsuario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
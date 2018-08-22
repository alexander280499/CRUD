using datospersonales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace datospersonales.Controllers
{
    public class datosController : Controller
    {
        datospersonalescontext obj=new datospersonalescontext();
        // GET: datos
        public ActionResult Index()
        {
            return View(obj.DatosPersonales.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(datospersonalesmodelo datos)
        {
            obj.DatosPersonales.Add(datos);
            obj.SaveChanges();
            return View("Index");
        }
        public ActionResult Details(int id)
        {
            var datos = obj.DatosPersonales.Find(id);
            return View(datos);
        }

        public ActionResult Edit(int id)
        {
            var datos = obj.DatosPersonales.Find(id);
            return View(datos);
        }

        [HttpPost]
        public ActionResult Edit(datospersonalesmodelo datosPerson)
        {
            obj.Entry(datosPerson).State = System.Data.Entity.EntityState.Modified;
            obj.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var datos = obj.DatosPersonales.Find(id);
            return View(datos);
        }

        [HttpPost]
        public ActionResult Delete(datospersonalesmodelo datos, int id)
        {
            var eliminar = obj.DatosPersonales.Find(id);
            obj.DatosPersonales.Remove(eliminar);
            obj.SaveChanges();
            return View(); 
        }
    }
}
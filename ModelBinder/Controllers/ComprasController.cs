using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBinder.Models;

namespace ModelBinder.Controllers
{
    public class ComprasController : Controller
    {
        // GET: Compras
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Salvar(Compras compras)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Alert = "Valor Inválido";
                return RedirectToAction("Index");
            }

            if (Session["Compras"] == null)
                Session["Compras"] = new List<Compras>();

            var lista = Session["Compras"] as List<Compras>;
            lista.Add(compras);

            return View(lista);
        }
    }
}
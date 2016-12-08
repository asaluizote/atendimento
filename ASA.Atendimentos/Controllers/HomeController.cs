using ASA.Atendimentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASA.Atendimentos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Tables()
        {
            return View();
        }

        [HttpPost]
        public JsonResult PopulateTable()
        {
            List<JsonTableViewModel> model = new List<JsonTableViewModel>();

            model.Add(new JsonTableViewModel { Id = 0, Name = "Jorge", Office = "Central", Position = "Analista", Salary = string.Format("{0:C}", 123.125), StartDate = "10/12/2016" });
            model.Add(new JsonTableViewModel { Id = 1, Name = "Elisa", Office = "Planalto", Position = "Enfermeira", Salary = string.Format("{0:C}", 4734.13), StartDate = "10/12/2016" });
            model.Add(new JsonTableViewModel { Id = 2, Name = "Roberto", Office = "Seap", Position = "Gerente", Salary = string.Format("{0:C}", 78954.78), StartDate = "10/12/2016" });
            model.Add(new JsonTableViewModel { Id = 3, Name = "Mario", Office = "Canaã", Position = "Policial", Salary = string.Format("{0:C}", 890.56), StartDate = "10/12/2016" });
            model.Add(new JsonTableViewModel { Id = 4, Name = "Carmem", Office = "Central", Position = "Cuidadora", Salary = string.Format("{0:C}", 1234.89), StartDate = "10/12/2016" });

            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
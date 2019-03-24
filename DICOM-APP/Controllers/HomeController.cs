using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DICOM_APP.Service;

namespace DICOM_APP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }
        public ActionResult Prueba()
        {
            return View();
        }
        public ActionResult CheckMessage()
        {
            ParserService p = new ParserService();
            var model = p.reader2();
            return View(model);
        }
        public ActionResult ListaAgendados()
        {
            PersonaService p = new PersonaService();
            var model= p.obtenerPersonas();
            return View(model);
        }
        public ActionResult Agenda()
        {
            return View();
        }

         
    }
}

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
            AgendamientoService a = new AgendamientoService();
            var model = a.listaAgendamientos(); 
            return View(model);
        }
        public ActionResult Agenda()
        {
            return View();
        }
        public ActionResult Servicio()
        {
            return View();
        }
        public ActionResult Date()
        {
            return View();
        }

         
    }
}

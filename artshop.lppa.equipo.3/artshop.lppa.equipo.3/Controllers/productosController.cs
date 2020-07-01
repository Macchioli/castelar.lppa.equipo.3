using artshop.lppa.equipo._3.DATA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace artshop.lppa.equipo._3.Controllers
{
    [Authorize]
    public class productosController : Controller
    {

        readonly IProductosData db;

        public productosController()
        {
            db = new InMemoryProductosData();
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public string Error()
        {
            return "Error!";
        }
    }
}
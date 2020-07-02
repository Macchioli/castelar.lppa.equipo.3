using artshop.lppa.equipo._3.DATA.Model;
using artshop.lppa.equipo._3.DATA.Services;
using artshop.lppa.equipo._3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace artshop.lppa.equipo._3.Controllers
{
    [Authorize]
    public class productosController : BaseController
    {

        private BaseDataService<Product> db;
        public productosController()
        {
            db = new BaseDataService<Product>();
        }
        public ActionResult Index()
        {
            var list = db.Get();
            return View(list);
        }
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product producto)
        {
            this.CheckAuditPattern(producto, true);
            var list = db.ValidateModel(producto);
            if (ModelIsValid(list))
                return View(producto);
            try
            {
                db.Create(producto);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                Logger.Instance.LogException(ex);
                ViewBag.MessageDanger = ex.Message;
                return View(producto);
            }

        }

        public string Error()
        {
            return "Error!";
        }
    }
}
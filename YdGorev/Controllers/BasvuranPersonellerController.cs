using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YdGorev.Models.EF;

namespace YdGorev.Controllers
{
    public class BasvuranPersonellerController : Controller
    {
        private YdGorevDbContext db = null;
        public BasvuranPersonellerController()
        {
            db = new YdGorevDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }
        // GET: BasvuranPersoneller
        public JsonResult GetList()
        {
            var personeller = db.BasvuranPersonellers.ToList();
            return Json(personeller, JsonRequestBehavior.AllowGet);
        }
    }
}

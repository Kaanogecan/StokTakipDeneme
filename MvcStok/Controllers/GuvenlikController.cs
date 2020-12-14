using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class GuvenlikController : Controller
    {
        MvcDbStokEntities db = new MvcDbStokEntities();
        // GET: Guvenlik
        public ActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(TBLKULLANICI t)
        {
            //test
            var bilgiler = db.TBLKULLANICI.FirstOrDefault(x => x.AD == t.AD && x.SIFRE == t.SIFRE);
            if (bilgiler != null)
            {
               return RedirectToAction("Index", "Kategori");
            }
            else
            {
                return View();
            }
           
        }
    }
}
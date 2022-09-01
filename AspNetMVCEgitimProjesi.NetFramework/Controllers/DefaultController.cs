using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCEgitimProjesi.NetFramework.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index() // bu action Index isimli view ı çalıştırır.
        {
            return View();
        }
    }
}
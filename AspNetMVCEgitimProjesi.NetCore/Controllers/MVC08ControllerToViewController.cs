using Microsoft.AspNetCore.Mvc;

namespace AspNetMVCEgitimProjesi.NetCore.Controllers
{
    public class MVC08ControllerToViewController : Controller
    {
        public IActionResult Index()
        {

            // MVC de temel olarak 3 türde view a veri yollama yapısı var.
            //1--ViewBag : Tek Kullanımlık Ömrü Var
            ViewBag.UrunKategorisi = "Bilgisayar";
            //2-ViewData : Tek Kullanımlık Ömrüğ var
            ViewData["UrunAdi"] = "Acer Monitor ";
            //3-TempData : 2 kullanımlık ömrü var
            TempData["UrunFiyati"] =35.18;

            return View();
        }
    }
}

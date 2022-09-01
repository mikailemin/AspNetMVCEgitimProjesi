using Microsoft.AspNetCore.Mvc;

namespace AspNetMVCEgitimProjesi.NetCore.Controllers
{
    public class MVC09ViewToControllerDataController : Controller
    {
        

        //Varsayılan method türü GET tir.
        public IActionResult Index(string txtAra)
        {

            ViewBag.GetVerisi = txtAra;
            return View();
        }

        [HttpPost] // Aşağıdaki metot sayfa (View)  port edildiğinde çalışır.
        public IActionResult Index(string text1,string ddlListe,bool cbOnay) 
        {

           // //1.Yöntem parametrelerden gelen verielr;
           // ViewBag.Mesaj = "Textboxdan gelen veri : " + text1;
           // ViewBag.MesajListe = "Liste den seçilen değer : " + ddlListe;
           // TempData["Tdata"] = "Checkbox dan seçilen değer : " + cbOnay;

           //// 2.Yöntem request form ile verileri yakalama



            ViewBag.Mesaj = "Textboxdan gelen veri : " + Request.Form["text1"];
            ViewBag.MesajListe = "Liste den seçilen değer : " + Request.Form["ddlListe"];
            TempData["Tdata"] = "Checkbox dan seçilen değer : " + Request.Form["cbOnay"];

            return View();
        }
    }
}

using AspNetMVCEgitimProjesi.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMVCEgitimProjesi.NetCore.Controllers
{
    public class MVC10ModelBindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Kullanici()
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad="Murat",
                Soyad="Yılmaz",
                Email="info@yönetici.com",
                KullaniciAdi="Murat",
                Sifre="123456"
            };
            return View(kullanici);
        }
        [HttpPost]
        public IActionResult Kullanici(Kullanici kullanici)
        {
            return View(kullanici);// Post işleminden sonra metoda parametreyle gelen kullanıcı nesnesini tekrar ekrana göstterme
        }
        public IActionResult Adres()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adres(Adres adres)
        {

            //Projelerde bu nokteda yakaladığımız adres nesnesini veritabanına kaydederiz.
            return View(adres);
        }

        public IActionResult UyeSayfasi()
        {

            Kullanici kullanici = new Kullanici()
            {
                Ad = "Murat",
                Soyad = "Yılmaz",
                Email = "info@yönetici.com",
                KullaniciAdi = "Murat",
                Sifre = "123456"
            };
            UyeSayfasiViewModel model =new UyeSayfasiViewModel()
            {
                Kullanici = kullanici,
                Adres=new Adres {Ilce="Ataşehir" , Sehir="İstanbul",AcikAdres="Menekşe sokak no:18" }
            };
            return View(model);
        }

    }
}

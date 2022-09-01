using System.ComponentModel.DataAnnotations;

namespace AspNetMVCEgitimProjesi.NetCore.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad alanı boş geçilemez"),StringLength(50)]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez"), StringLength(50)]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez"), StringLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez"), StringLength(50)]
        public string Telefon { get; set; }
        [Phone(ErrorMessage ="yanlşış giriş")]
        public string TcKimlikNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string SifreTekrar { get; set; }
    }
}

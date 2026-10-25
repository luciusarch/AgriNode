using Microsoft.AspNetCore.Mvc;
using AgriNode.Models;
using System.Collections.Generic;
using System.Linq;

namespace AgriNode.Controllers
{
    public class CropController : Controller
    {
        // Veritabanı simülasyonu için geçici statik liste (Proje çalıştığı sürece veriyi tutar)
        private static List<CropModel> _cropList = new List<CropModel>();

        // 1. Sayfa: Mahsullerin Listelendiği ve Mesajın Görüldüğü Yer
        public IActionResult Index()
        {
            // TempData View'a otomatik gider, listeyi de Model olarak gönderiyoruz.
            return View(_cropList);
        }

        // 2. Sayfa (GET): Formun Ekrana Gelmesi
        [HttpGet]
        public IActionResult AddCrop()
        {
            return View(new CropModel());
        }

        // 2. Sayfa (POST): Formdan Gelen Verinin Yakalanması
        [HttpPost]
        public IActionResult AddCrop(CropModel model)
        {
            if (ModelState.IsValid)
            {
                // Veriyi listeye (sözde veritabanına) ekle
                model.Id = _cropList.Any() ? _cropList.Max(c => c.Id) + 1 : 1;
                _cropList.Add(model);

                // Hocanın istediği sayfalar arası veri taşıma (Alert için)
                TempData["SuccessMessage"] = $"{model.Name} isimli {model.Type} mahsulü başarıyla sisteme eklendi!";

                // Veriyi gösterdiğimiz Index sayfasına yönlendir
                return RedirectToAction("Index");
            }

            // Hata varsa aynı sayfayı hatalarla geri döndür
            return View(model);
        }
    }
}
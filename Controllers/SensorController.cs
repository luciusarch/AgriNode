using Microsoft.AspNetCore.Mvc;
using AgriNode.Models;
using System.Collections.Generic;
using System.Linq;

namespace AgriNode.Controllers
{
    public class SensorController : Controller
    {
        // Başlangıçta tablo dolu gelsin diye 3 örnek sensör ekliyoruz
        private static List<SensorModel> _sensorList = new List<SensorModel>
        {
            new SensorModel { Id = 1, Location = "Sera 1 - Kuzey", SensorType = "Toprak Nemi", LastValue = 45.2, Unit = "%", IsActive = true },
            new SensorModel { Id = 2, Location = "Sera 1 - Güney", SensorType = "Hava Sıcaklığı", LastValue = 26.8, Unit = "°C", IsActive = true },
            new SensorModel { Id = 3, Location = "Açık Tarla B2", SensorType = "Toprak pH", LastValue = 6.5, Unit = "pH", IsActive = false }
        };

        // 1. View: Sensörlerin Listesi
        public IActionResult Index()
        {
            return View(_sensorList);
        }

        // 2. View (GET): Sensör Ekleme / Kalibrasyon Formu
        [HttpGet]
        public IActionResult Calibration()
        {
            return View(new SensorModel());
        }

        // 2. View (POST): Kalibrasyon verisini alıp Index sayfasına taşıma
        [HttpPost]
        public IActionResult Calibration(SensorModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = _sensorList.Any() ? _sensorList.Max(s => s.Id) + 1 : 1;
                _sensorList.Add(model);

                TempData["SensorMessage"] = $"{model.Location} konumundaki {model.SensorType} sensörü başarıyla kalibre edildi ve eklendi!";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
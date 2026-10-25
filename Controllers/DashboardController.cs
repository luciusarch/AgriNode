using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AgriNode.Controllers
{
    public class DashboardController : Controller
    {
        // 1. View: Genel Sistem Özeti
        public IActionResult Index()
        {
            // View'da kullanmak üzere ViewBag ile özet istatistikler gönderiyoruz
            ViewBag.TotalActiveSensors = 12;
            ViewBag.AverageTemperature = "24.5 °C";
            ViewBag.AverageHumidity = "%58";
            ViewBag.WaterTankLevel = "%82";

            return View();
        }

        // 2. View: Sistem ve İklim Uyarıları
        public IActionResult Alerts()
        {
            // Dinamik listeleme için örnek uyarı listesi
            var alerts = new List<string>
            {
                "KRİTİK: Sera 2'de toprak nemi %20'nin altına düştü! Sulama sistemini başlatın.",
                "UYARI: Yarın bölge genelinde şiddetli rüzgar bekleniyor.",
                "BİLGİ: Açık Tarla B2 pH sensörü kalibrasyon zamanı geldi."
            };

            return View(alerts);
        }
    }
}
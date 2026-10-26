using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AgriNode.ViewComponents
{
    public class ActiveAlertsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var activeAlerts = new List<string>
            {
                "Sera-1 bölgesinde toprak nem oranı kritik seviyenin (%25) altına düştü.",
                "Sera-2 sıcaklık sensörü 32.5 °C ölçtü — havalandırma fanları kontrol edilmeli.",
                "Ana su tankı doluluk oranı %30 seviyesine geriledi.",
                "Tarla-B pH sensörü için haftalık kalibrasyon zamanı geldi."
            };

            return View(activeAlerts);
        }
    }
}
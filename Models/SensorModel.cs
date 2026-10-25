using System;
using System.ComponentModel.DataAnnotations;

namespace AgriNode.Models
{
    public class SensorModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Sensör adı/konumu zorunludur.")]
        [Display(Name = "Sensör Konumu / Adı")]
        public string Location { get; set; } = string.Empty;

        [Display(Name = "Sensör Tipi")]
        public string SensorType { get; set; } = string.Empty; // Nem, Sıcaklık, pH vb.

        [Display(Name = "Son Ölçüm Değeri")]
        public double LastValue { get; set; }

        [Display(Name = "Birim")]
        public string Unit { get; set; } = string.Empty; // %, °C, pH

        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; } = true;
    }
}
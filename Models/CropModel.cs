using System;
using System.ComponentModel.DataAnnotations;

namespace AgriNode.Models
{
    public class CropModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Mahsul adi zorunludur.")]
        [Display(Name = "Mahsul Adi")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mahsul turu secsilmelidir.")]
        [Display(Name = "Mahsul Türü")]
        public string Type { get; set; }

        [Display(Name = "Ekim Tarihi")]
        [DataType(DataType.Date)]
        public DateTime PlantingDate { get; set; }
    }
}
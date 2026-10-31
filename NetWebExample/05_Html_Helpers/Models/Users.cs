using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace _05_Html_Helpers.Models
{
    public class Users
    {
        [Required(ErrorMessage = "Ad Zorunludur")]
        [Display(Name = "Ad")]//Label bu alanı kullanacak
        public string? Name { get; set; }//? allow nulls yapısını aktifleştirir.
        [Range(18,120,ErrorMessage ="Yaş 18 ile 120 arasında olmalıdır")]
        [Display(Name ="Yaş")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Cinsiyet Zorunludur")]
        [Display(Name ="Cinsiyet")]
        public string? Gender { get; set; }

        [Required(ErrorMessage ="Ülke zorunludur")]
        [Display(Name ="Ülke")]
        public string? Country { get; set; }
        public IEnumerable<SelectListItem> CountryList { get; set; } = [];


    }
}

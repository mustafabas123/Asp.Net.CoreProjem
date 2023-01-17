using System.ComponentModel.DataAnnotations;

namespace ProjectPresentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name = "Başlık")]
        [Required(ErrorMessage ="Basşlık Boş Geçilemez")]
        public string Title { get; set; }

        [Display(Name ="Açıklama")]
        [Required(ErrorMessage ="Açıklama Kısmı boş geçilemez")]
        public string Description { get; set; }

        [Display(Name ="Resim")]
        [Required(ErrorMessage ="Resim kısmı Boş geçilemez")]
        public string Image { get; set; }
    }
}

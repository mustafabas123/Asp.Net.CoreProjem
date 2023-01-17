using System.ComponentModel.DataAnnotations;

namespace ProjectPresentation.Models
{
    public class NewsAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Başlık Boş geçilemez")]
        public string Title { get; set; }

        [Display(Name ="Açıklama")]
        [Required(ErrorMessage ="Açıklama Boş geçilemez")]
        public string Description { get; set; }

        [Display(Name ="Eklenme Tarihi")]
        public DateTime Date { get; set; }
    }
}

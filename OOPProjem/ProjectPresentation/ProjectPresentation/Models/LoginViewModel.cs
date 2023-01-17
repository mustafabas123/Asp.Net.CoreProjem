using System.ComponentModel.DataAnnotations;

namespace ProjectPresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen Bir Kullanııc Adı Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen Bir Şifre Giriniz")]
        public string Password { get; set; }
    }
}

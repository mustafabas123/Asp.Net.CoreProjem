using System.ComponentModel.DataAnnotations;
namespace ProjectPresentation.Models
{
	public class RegisterViewModel
	{
        //Kayıt işleminde hangi alanların olmasını istiyorsan bu kısımda propoties olarak tanımlamalısın


        [Required(ErrorMessage ="Lütfen isim Giriniz")]
		public string Name { get; set; }

		[Required(ErrorMessage ="Lütfen Soyisim Giriniz")]
		public string Surname { get; set; }
		[Required(ErrorMessage ="Lütfen Kullanıcı Adı Giriniz")]
		public string UserName { get; set; }


		[Required(ErrorMessage ="Lütfen Mail Adresinizi Giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage ="Şifreyi Giriniz")]
		public string Pasword { get; set; }

		[Required(ErrorMessage ="Şifrenizi Tekrar giriniz")]
		[Compare("Pasword", ErrorMessage ="Şifreler Uyumlu değil") ]
		public string RePassword { get; set; }

	}
}

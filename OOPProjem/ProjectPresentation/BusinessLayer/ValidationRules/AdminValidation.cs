using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AdminValidation:AbstractValidator<Admins>
	{
		public AdminValidation()
		{
			RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez");
			RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Kullanıcı Adı en fazla 20 karakterli olabilir");
			RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı Adı en az 3 Karakterli olabilir");

			RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
			RuleFor(x => x.Password).MaximumLength(20).WithMessage("Şifre En fazla 20 karakterli olabilir");
			RuleFor(x => x.Password).MinimumLength(3).WithMessage("Şifre En az 3 karakterli olabilir");
		}	
	}
}

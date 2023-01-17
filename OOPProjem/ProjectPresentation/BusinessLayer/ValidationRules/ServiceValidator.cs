using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ServiceValidator:AbstractValidator<Service>
    {
        public ServiceValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Kısmı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmı Boş geçilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Dosya yolu boş Geçilemez");
        }
    }
}

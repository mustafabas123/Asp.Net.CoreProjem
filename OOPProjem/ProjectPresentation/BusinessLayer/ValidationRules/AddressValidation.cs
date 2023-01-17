using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidation:AbstractValidator<Address>
    {
        public AddressValidation()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Tarif Kısmı Boş geçilemez");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Tarif Kısmı Boş geçilemez");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Tarif Kısmı Boş geçilemez");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Tarif Kısmı Boş geçilemez");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Harita bilgisi Boş geçilemez");

        }
    }
}

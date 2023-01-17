using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PersonelValidator:AbstractValidator<Personels>
    {
        public PersonelValidator() 
        {
            RuleFor(x => x.PersonelName).NotEmpty().WithMessage("Personel Adı Boş geçilmez");
            RuleFor(x => x.PersonelName).MinimumLength(3).WithMessage("Personel Adı en az 3 karakterli olmalı");
            RuleFor(x => x.PersonelName).MaximumLength(20).WithMessage("Personel Adı En fazla 20 Karakterli olmalı");


            RuleFor(x => x.Title).NotEmpty().WithMessage("Personel Görevi Boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Personelin Görevi En az 3 karakterli Olmalı");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Personelin Görevi En fazla 20 karakterli olmalı");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Yolu Boş geçilemez");
        }
    }
}

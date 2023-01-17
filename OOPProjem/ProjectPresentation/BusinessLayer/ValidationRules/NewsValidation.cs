using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class NewsValidation:AbstractValidator<News>
    {
        public NewsValidation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Kısmı boş gecilemez");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Başlık Kısmı en az 3 karakterli olmalı");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Başlık Kısmı en fazla 20 karakterli olmalı");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmı boş geçilemez");
            RuleFor(x => x.Description).MinimumLength(3).WithMessage("Açıklama Kısmı En az 3 karakter içerebilir");
        }
    }
}

using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidation:AbstractValidator<Image>
    {
        public ImageValidation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Kısmı boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Başlık Kısmı En az 3 karakterli olmalı");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Başlık kısmı En fazla 20 karakterli olmalı");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Yolu Boş geçilemez");
        }
    }
}

using _11_FluentValidation.Models;
using FluentValidation;

namespace _11_FluentValidation.Validators
{
    public class KisiValidator:AbstractValidator<Kisi>
    {
        public KisiValidator()
        {
            RuleFor(k => k.Ad).NotEmpty().WithMessage("Ad alanı boş olamaz")
                .MaximumLength(50).WithMessage("Maks 50 karakter olmalı")
                .MinimumLength(3).WithMessage("Min 3 karakter olmalı");
            RuleFor(k => k.Soyad).NotEmpty().WithMessage("Soyad alanı boş olamaz")
                .MaximumLength(50).WithMessage("Maks 50 karakter olmalı")
                .MinimumLength(3).WithMessage("Min 3 karakter olmalı");
            RuleFor(k => k.Yas)
                .NotNull().WithMessage("Yaş Zorunlu")
                .InclusiveBetween(1, 119).WithMessage("Yaş 1 ila 119 arasında olmalıdır");
        }
    }
}

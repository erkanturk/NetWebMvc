using _11_FluentValidation.Models;
using FluentValidation;

namespace _11_FluentValidation.Validators
{
    public class AdresValidator:AbstractValidator<Adres>
    {
        public AdresValidator()
        {
            RuleFor(a => a.AdresTanim)
                .NotEmpty().WithMessage("Adres Tanım Boş Bırakılamaz")
                .MaximumLength(100).WithMessage("Maksimum uzunluk 100 karakter olabilir");
            RuleFor(a => a.Sehir).NotEmpty().WithMessage("Şehir boş olamaz")
                .MaximumLength(50).WithMessage("Maksimum 50 karakter olabilir.");
        }
    }
}

using System;
using FluentValidation;
using DecoratorPatternMediatr.Entity;

namespace DecoratorPatternMediatr.Validator
{
    public class CreatorValidator : AbstractValidator<Creator>
    {
        public CreatorValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("Nama tidak boleh kosong");
            RuleFor(x => x.age).NotEmpty().WithMessage("Usia tidak boleh kosong");

        }
    }
}

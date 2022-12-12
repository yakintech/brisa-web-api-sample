using System;
using FluentValidation;

namespace BrisaWebApiSample.Models
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {

        public SupplierValidator()
        {
            RuleFor(q => q.CompanyName)
                .NotEmpty().WithMessage("CompanyName alanı boş bırakılamaz")
                .MaximumLength(50).WithMessage("örnek mesaj");

            RuleFor(q => q.ContactName)
                .NotEmpty().WithMessage("ContactName alanı boş bırakılamaz");
        }

    }
}


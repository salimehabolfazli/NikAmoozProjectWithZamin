using FluentValidation;
using WebLog.Core.Contracts.Products.Commands.CreateProduct;
using WebLog.Core.Domain;
using Zamin.Extensions.Translations.Abstractions;

namespace WebLog.Core.ApplicationService.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        private readonly ITranslator _translator;
        public CreateProductCommandValidator(ITranslator translator)
        {
            _translator = translator;

            RuleFor(c => c.Title)
               .NotEmpty().WithMessage(_translator[PersonResource.ProductTitleRequiredError])
                .MinimumLength(2).WithMessage(_translator[PersonResource.ProductTitleStringLengthError])
                .MaximumLength(50).WithMessage(_translator[PersonResource.ProductTitleStringLengthError]);

        }
    }
}

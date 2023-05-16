using FluentValidation;
using WebLog.Core.Contracts.Products.Commands.UpdateProduct;
using WebLog.Core.Domain;
using Zamin.Extensions.Translations.Abstractions;

namespace WebLog.Core.ApplicationService.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        private readonly ITranslator _translator;
        public UpdateProductCommandValidator(ITranslator translator)
        {
            _translator = translator;

            RuleFor(c => c.ProductId)
               .NotEmpty().WithMessage(_translator[PersonResource.IdRequiredError]);
        }
    }
}

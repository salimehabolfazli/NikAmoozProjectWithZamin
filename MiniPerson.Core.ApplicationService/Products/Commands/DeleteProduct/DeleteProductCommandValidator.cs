using FluentValidation;
using WebLog.Core.Contracts.Products.Commands.DeleteProduct;
using WebLog.Core.Domain;
using Zamin.Extensions.Translations.Abstractions;

namespace WebLog.Core.ApplicationService.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
    {
        private readonly ITranslator _translator;
        public DeleteProductCommandValidator(ITranslator translator)
        {
            _translator = translator;

            RuleFor(c => c.ProductId)
               .NotEmpty().WithMessage(_translator[PersonResource.IdRequiredError]);
        }
    }
}

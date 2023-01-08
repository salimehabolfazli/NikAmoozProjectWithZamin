using FluentValidation;
using GymProducts.Core.Domain;
using MiniPerson.Core.Contracts.Products.Commands.UpdateProduct;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniPerson.Core.ApplicationService.People.Commands.DeletePerson
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

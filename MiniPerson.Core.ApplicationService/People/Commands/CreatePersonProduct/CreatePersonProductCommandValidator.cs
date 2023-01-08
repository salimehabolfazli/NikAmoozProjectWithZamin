using FluentValidation;
using GymProducts.Core.Domain;
using MiniPerson.Core.Contracts.People.Cammands.CreatePersonProduct;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniPerson.Core.ApplicationService.People.Commands.CreatePersonProduct
{
    public class CreatePersonProductCommandValidator : AbstractValidator<CreatePersonProductCommand>
    {
        private readonly ITranslator _translator;
        public CreatePersonProductCommandValidator(ITranslator translator)
        {
            _translator = translator;

            RuleFor(c => c.ProductId)
               .NotEmpty().WithMessage(_translator[PersonResource.PersonProductRequiredError]);

            RuleFor(c => c.PersonId)
               .NotEmpty().WithMessage(_translator[PersonResource.PersonProductRequiredError]);
        }
    }
}

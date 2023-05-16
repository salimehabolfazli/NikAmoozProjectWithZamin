using FluentValidation;
using WebLog.Core.Contracts.People.Commands.CreatePersonProduct;
using WebLog.Core.Domain;
using Zamin.Extensions.Translations.Abstractions;

namespace WebLog.Core.ApplicationService.People.Commands.CreatePersonProduct
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

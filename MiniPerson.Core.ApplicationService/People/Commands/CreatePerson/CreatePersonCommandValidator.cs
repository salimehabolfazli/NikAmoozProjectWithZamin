using FluentValidation;
using GymProducts.Core.Domain;
using MiniPerson.Core.Contracts.People.Commands.CreatePerson;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniPerson.Core.ApplicationService.People.Commands.CreatePerson
{
    public class CreatePersonCommandValidator : AbstractValidator<CreatePersonCommand>
    {
        private readonly ITranslator _translator;
        public CreatePersonCommandValidator(ITranslator translator)
        {
            _translator = translator;

            RuleFor(c => c.FirstName)
               .NotEmpty().WithMessage(_translator[PersonResource.PersonFirstnameRequiredError])
                .MinimumLength(2).WithMessage(_translator[PersonResource.PersonFirstnameStringLengthError])
                .MaximumLength(50).WithMessage(_translator[PersonResource.PersonFirstnameStringLengthError]);

            RuleFor(c => c.LastName)
               .NotEmpty().WithMessage(_translator[PersonResource.PersonLastnameRequiredError])
                .MinimumLength(2).WithMessage(_translator[PersonResource.PersonLastnameStringLengthError])
                .MaximumLength(50).WithMessage(_translator[PersonResource.PersonLastnameStringLengthError]);
        }
    }
}

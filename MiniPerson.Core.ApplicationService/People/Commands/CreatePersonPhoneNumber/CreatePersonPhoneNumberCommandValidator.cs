using FluentValidation;
using GymProducts.Core.Domain;
using MiniPerson.Core.Contracts.People.Commands.CreatePerson;
using MiniPerson.Core.Contracts.People.CreatePersonPhoneNumber;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniPerson.Core.ApplicationService.People.Commands.CreatePersonPhoneNumber
{
    public class CreatePersonPhoneNumberCommandValidator : AbstractValidator<CreatePersonPhoneNumberCommand>
    {
        private readonly ITranslator _translator;
        public CreatePersonPhoneNumberCommandValidator(ITranslator translator)
        {
            _translator = translator;

            RuleFor(c => c.Value)
               .NotEmpty().WithMessage(_translator[PersonResource.PersonPhoneNumberExistError])
                .Length(11).WithMessage(_translator[PersonResource.PersonPhoneNumberStringLengthError]);

            RuleFor(c => c.PersonId)
               .NotEmpty().WithMessage(_translator[PersonResource.PersonPhoneNumberExistError]);
        }
    }
}

using FluentValidation;
using WebLog.Core.Contracts.People.Commands.CreatePerson;
using WebLog.Core.Contracts.People.Commands.CreatePersonPhoneNumber;
using WebLog.Core.Domain;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Extensions.Translations.Abstractions;

namespace WebLog.Core.ApplicationService.People.Commands.CreatePersonPhoneNumber
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

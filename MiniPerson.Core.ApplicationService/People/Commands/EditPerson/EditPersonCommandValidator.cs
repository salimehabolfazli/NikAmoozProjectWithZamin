using FluentValidation;
using WebLog.Core.Contracts.People.Commands.EditPerson;
using WebLog.Core.Domain;
using Zamin.Extensions.Translations.Abstractions;

namespace WebLog.Core.ApplicationService.People.Commands.EditPerson
{
    public class EditPersonCommandValidator : AbstractValidator<EditPersonCommand>
    {
        private readonly ITranslator _translator;
        public EditPersonCommandValidator(ITranslator translator)
        {
            _translator = translator;

            RuleFor(c => c.PersonId)
               .NotEmpty().WithMessage(_translator[PersonResource.IdRequiredError]);
        }
    }
}

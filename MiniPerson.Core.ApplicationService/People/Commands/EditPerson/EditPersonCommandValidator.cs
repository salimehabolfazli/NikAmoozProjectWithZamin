using FluentValidation;
using GymProducts.Core.Domain;
using MiniPerson.Core.Contracts.People.Commands.EditPerson;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniPerson.Core.ApplicationService.People.Commands.EditPerson
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

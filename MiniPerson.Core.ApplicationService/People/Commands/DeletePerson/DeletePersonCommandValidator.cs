using FluentValidation;
using WebLog.Core.Contracts.People.Commands.DeletePerson;
using WebLog.Core.Domain;
using Zamin.Extensions.Translations.Abstractions;

namespace WebLog.Core.ApplicationService.People.Commands.DeletePerson
{
    public class DeletePersonCommandValidator : AbstractValidator<DeletePersonCommand>
    {
        private readonly ITranslator _translator;
        public DeletePersonCommandValidator(ITranslator translator)
        {
            _translator = translator;

            RuleFor(c => c.PersonId)
               .NotEmpty().WithMessage(_translator[PersonResource.IdRequiredError]);
        }
    }
}

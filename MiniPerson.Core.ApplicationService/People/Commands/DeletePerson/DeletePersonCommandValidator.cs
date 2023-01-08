using FluentValidation;
using GymProducts.Core.Domain;
using MiniPerson.Core.Contracts.People.Commands.DeletePerson;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniPerson.Core.ApplicationService.People.Commands.DeletePerson
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

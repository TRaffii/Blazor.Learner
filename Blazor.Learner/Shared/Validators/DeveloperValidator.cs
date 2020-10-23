using Blazor.Learner.Shared.Models;
using FluentValidation;

public class DeveloperValidator : AbstractValidator<Developer>
{
    public DeveloperValidator()
    {
        RuleFor(Q => Q.Email).NotEmpty().EmailAddress().MaximumLength(255);
    }
}
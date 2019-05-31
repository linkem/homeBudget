using FluentValidation;
using HomeBudget.Models.Bills;

namespace HomeBudget.Validations
{
    public class AddBillViewModelValidator : AbstractValidator<AddBillViewModel>
    {
        public AddBillViewModelValidator()
        {
            RuleFor(x => x.Amount)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(x => x.Description)
                .NotEmpty();

            RuleFor(x => x.PersonId)
                .NotEmpty();
        }
    }
}

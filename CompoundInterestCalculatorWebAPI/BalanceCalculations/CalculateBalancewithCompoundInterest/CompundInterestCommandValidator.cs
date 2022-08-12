using FluentValidation;

namespace CompoundInterestCalculatorWebAPI.BalanceCalculations.CalculateBalancewithCompoundInterest
{
    public class CompundInterestCommandValidator : AbstractValidator<CompoundInterestCommand>
    // This means that "CompundInterestCommandValidator" validates the "CompoundInterestCommand" class.
    // This validator is interested in the inputs of CompoundInterestCommand class.

    {
        public CompundInterestCommandValidator()
        {
            RuleFor(command => command.Model.InitialPrincipal).NotEmpty().GreaterThanOrEqualTo(0);
            RuleFor(command => command.Model.InterestRate).NotEmpty().GreaterThanOrEqualTo(0);
            RuleFor(command => command.Model.CompoundInterval).NotEmpty().GreaterThanOrEqualTo(0);
        }
    }
}

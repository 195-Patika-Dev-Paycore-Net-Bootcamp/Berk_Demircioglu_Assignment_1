
using System.ComponentModel.DataAnnotations;

namespace CompoundInterestCalculatorWebAPI.Models
{
    public class CompoundInterest
    {
        
        public double InitialPrincipal { get; set; } // The property that represents the invested money

        public double InterestRate { get; set; } // The property that represents the amount of interest due per period

        public double CompoundInterval { get; set; } // The property that represents the investment time period

    }
}

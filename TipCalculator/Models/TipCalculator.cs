using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "Please enter a cost.")]
        [Range(.01, double.PositiveInfinity, ErrorMessage = "Cost amount must be greater than 0")]

        public decimal? Cost { get; set; }
        public decimal? FifteenPerTip { get; set; }
        public decimal? TwentyPerTip { get; set; }
        public decimal? TwentyFivePerTip { get; set; }

        public decimal? GetTip(decimal tip)
        {
            decimal? TotalTip = this.Cost * (tip / 100);
            return TotalTip;
        }

    }
}

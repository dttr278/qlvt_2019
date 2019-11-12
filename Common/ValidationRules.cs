using System.Globalization;
using System.Windows.Controls;

namespace WpfApp2
{
    class ReqireValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
                return new ValidationResult(false, "Value cannot be empty.");
            else
            {
                if (value.ToString().Trim().Length == 0)
                    return new ValidationResult(false, "Value cannot be empty.");
            }
            return ValidationResult.ValidResult;
        }
    }
    class AwayFalse : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return new ValidationResult(false, "moahahahaha");
        }
    }
    public class MinimumCharacterRule : ValidationRule
    {
        public int MinimumCharacters { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;

            if (charString.Length < MinimumCharacters)
                return new ValidationResult(false, $"User atleast {MinimumCharacters} characters.");

            return new ValidationResult(true, null);
        }
    }
}

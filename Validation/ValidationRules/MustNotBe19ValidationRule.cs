using System.Globalization;
using System.Windows.Controls;

namespace Validation.ValidationRules
{
    internal class MustNotBe19ValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var text = value as string;

            if (int.TryParse(text, out int zahl) && zahl != 19)
                return ValidationResult.ValidResult;

            return new ValidationResult(isValid: false, errorContent: "Zahl darf nicht 19 sein!");
        }
    }
}

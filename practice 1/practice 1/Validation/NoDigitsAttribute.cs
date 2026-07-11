using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace practice_1.Validation
{
    public class NoDigitsAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            // If no value is entered, let [Required] handle it
            if (value == null)
            {
                return ValidationResult.Success;
            }

            string text = value.ToString();

            // Check whether the text contains any digit (0-9)
            if (Regex.IsMatch(text, @"\d"))
            {
                return new ValidationResult("Applicant name cannot contain numeric digits.");
            }

            return ValidationResult.Success;
        }
    }
}
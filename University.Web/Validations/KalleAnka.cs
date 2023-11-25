using System.ComponentModel.DataAnnotations;

namespace University.Web.Validations
{
    public class KalleAnka : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            const string errorMessage = "Fail from Kalle Anka";

            if (value is string input)
            {
                if (validationContext.ObjectInstance is StudentCreateViewModel model)
                {
                    return model.NameFirstName == "Kalle" && input == "Anka" ?
                        ValidationResult.Success :
                        new ValidationResult(errorMessage);
                }
            }
            return new ValidationResult(errorMessage);
        }

    }
}

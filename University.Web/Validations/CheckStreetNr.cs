using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace University.Web.Validations
{
    public class CheckStreetNr : ValidationAttribute, IClientModelValidator
    {
        private readonly int max;

        public CheckStreetNr(int max = 20)
        {
            this.max = max;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-streetnr", "Error from JS");
            context.Attributes.Add("data-val-streetnr-max", $"{max}");

        }

        public override bool IsValid(object? value)
        {
            if (value is string input)
            {
                var num = input.Trim().Split().Last();
                return int.TryParse(num, out int res) & res <= max;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Net;
using System.IO;

namespace NumberGuessingMvcClient.Models
{
    public class GenerateSecretNumber
    {
        [Required(ErrorMessage ="Please enter a lower limit")]
        public int lowerLimit { get; set; }
        [Required(ErrorMessage = "Please enter a upper limit")]
        [GreaterThan("lowerLimit", "Upper limit must be greater than lower limit")]

        public int upperLimit { get; set; }

        
    }

    public class GreaterThan : ValidationAttribute
    {
        private string lowerLimitPropertyName;
        private string errorMessage;
        public GreaterThan(string lowerLimitPropertyName, string errorMessage)
        {
            this.lowerLimitPropertyName = lowerLimitPropertyName;
            this.errorMessage = errorMessage;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var propertyInfo = validationContext.ObjectType.GetProperty(lowerLimitPropertyName);
            var propertyValue = propertyInfo.GetValue(validationContext.ObjectInstance, null);
            if ((int)value > (int)propertyValue)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(errorMessage);
            }
        }
    }
}

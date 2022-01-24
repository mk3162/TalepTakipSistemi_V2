using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.CrossCuttingConcern.Validations.FluentValidation
{
    public class FluentValidationsTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var result = validator.Validate((IValidationContext)entity);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}

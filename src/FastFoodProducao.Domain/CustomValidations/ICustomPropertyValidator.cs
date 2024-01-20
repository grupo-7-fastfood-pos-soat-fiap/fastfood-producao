﻿using FluentValidation.Validators;

namespace FastFoodProducao.Domain.CustomValidations
{
    public interface ICustomPropertyValidator
    {
        interface ICustomPropertyValidator : IPropertyValidator
        {
        }
    }
}

using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class CcPaymentMethodsCreateModelValidator
        : AbstractValidator<CcPaymentMethodsCreateModel>
    {
        public CcPaymentMethodsCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}

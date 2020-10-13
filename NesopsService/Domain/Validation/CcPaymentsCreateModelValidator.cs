using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class CcPaymentsCreateModelValidator
        : AbstractValidator<CcPaymentsCreateModel>
    {
        public CcPaymentsCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}

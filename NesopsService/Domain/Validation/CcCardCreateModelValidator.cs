using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class CcCardCreateModelValidator
        : AbstractValidator<CcCardCreateModel>
    {
        public CcCardCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}

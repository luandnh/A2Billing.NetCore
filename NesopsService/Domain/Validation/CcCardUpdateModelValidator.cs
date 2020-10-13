using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class CcCardUpdateModelValidator
        : AbstractValidator<CcCardUpdateModel>
    {
        public CcCardUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}

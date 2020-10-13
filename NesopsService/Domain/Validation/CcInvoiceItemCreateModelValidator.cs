using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class CcInvoiceItemCreateModelValidator
        : AbstractValidator<CcInvoiceItemCreateModel>
    {
        public CcInvoiceItemCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}

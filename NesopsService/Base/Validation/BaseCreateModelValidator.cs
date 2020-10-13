using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class BaseCreateModelValidator
        : AbstractValidator<BaseCreateModel>
    {
        public BaseCreateModelValidator()
        {
        }
    }
}

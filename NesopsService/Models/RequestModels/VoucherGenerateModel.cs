using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Models.RequestModels
{
    public class VoucherGenerateModel
    {
        public int quantity { get; set; }
        public float credit { get; set; }
        public DateTime exprireDate { get; set; } = DateTime.UtcNow.AddHours(7).AddDays(10);
    }
    public partial class VoucherGenerateModelValidator
    : AbstractValidator<VoucherGenerateModel>
    {
        public VoucherGenerateModelValidator()
        {
            RuleFor(p => p.quantity).InclusiveBetween(1, 100);
            RuleFor(p => p.credit).InclusiveBetween(1, 100);
            RuleFor(p => p.exprireDate).GreaterThanOrEqualTo(DateTime.UtcNow.AddHours(7).AddDays(1));
        }

    }
}

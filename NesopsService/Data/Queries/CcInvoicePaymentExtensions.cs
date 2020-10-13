using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcInvoicePaymentExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcInvoicePayment GetByKey(this IQueryable<NesopsService.Data.Entities.CcInvoicePayment> queryable, long idInvoice, long idPayment)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcInvoicePayment> dbSet)
                return dbSet.Find(idInvoice, idPayment);

            return queryable.FirstOrDefault(q => q.IdInvoice == idInvoice
                && q.IdPayment == idPayment);
        }

        public static ValueTask<NesopsService.Data.Entities.CcInvoicePayment> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcInvoicePayment> queryable, long idInvoice, long idPayment)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcInvoicePayment> dbSet)
                return dbSet.FindAsync(idInvoice, idPayment);

            var task = queryable.FirstOrDefaultAsync(q => q.IdInvoice == idInvoice
                && q.IdPayment == idPayment);
            return new ValueTask<NesopsService.Data.Entities.CcInvoicePayment>(task);
        }

        #endregion

    }
}

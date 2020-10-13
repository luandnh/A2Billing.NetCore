using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcInvoiceExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcInvoice GetByKey(this IQueryable<NesopsService.Data.Entities.CcInvoice> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcInvoice> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcInvoice> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcInvoice> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcInvoice> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcInvoice>(task);
        }

        public static NesopsService.Data.Entities.CcInvoice GetByReference(this IQueryable<NesopsService.Data.Entities.CcInvoice> queryable, string reference)
        {
            return queryable.FirstOrDefault(q => (q.Reference == reference || (reference == null && q.Reference == null)));
        }

        public static Task<NesopsService.Data.Entities.CcInvoice> GetByReferenceAsync(this IQueryable<NesopsService.Data.Entities.CcInvoice> queryable, string reference)
        {
            return queryable.FirstOrDefaultAsync(q => (q.Reference == reference || (reference == null && q.Reference == null)));
        }

        #endregion

    }
}

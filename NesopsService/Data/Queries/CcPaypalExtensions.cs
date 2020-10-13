using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcPaypalExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcPaypal GetByKey(this IQueryable<NesopsService.Data.Entities.CcPaypal> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPaypal> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcPaypal> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcPaypal> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPaypal> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcPaypal>(task);
        }

        public static NesopsService.Data.Entities.CcPaypal GetByTxnId(this IQueryable<NesopsService.Data.Entities.CcPaypal> queryable, string txnId)
        {
            return queryable.FirstOrDefault(q => (q.TxnId == txnId || (txnId == null && q.TxnId == null)));
        }

        public static Task<NesopsService.Data.Entities.CcPaypal> GetByTxnIdAsync(this IQueryable<NesopsService.Data.Entities.CcPaypal> queryable, string txnId)
        {
            return queryable.FirstOrDefaultAsync(q => (q.TxnId == txnId || (txnId == null && q.TxnId == null)));
        }

        #endregion

    }
}

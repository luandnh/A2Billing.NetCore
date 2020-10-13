using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcReceiptExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcReceipt GetByKey(this IQueryable<NesopsService.Data.Entities.CcReceipt> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcReceipt> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcReceipt> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcReceipt> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcReceipt> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcReceipt>(task);
        }

        #endregion

    }
}

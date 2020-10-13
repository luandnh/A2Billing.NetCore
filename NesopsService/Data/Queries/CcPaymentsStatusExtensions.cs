using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcPaymentsStatusExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcPaymentsStatus GetByKey(this IQueryable<NesopsService.Data.Entities.CcPaymentsStatus> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPaymentsStatus> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcPaymentsStatus> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcPaymentsStatus> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPaymentsStatus> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcPaymentsStatus>(task);
        }

        #endregion

    }
}

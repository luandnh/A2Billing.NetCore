using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCardSubscriptionExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCardSubscription GetByKey(this IQueryable<NesopsService.Data.Entities.CcCardSubscription> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardSubscription> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCardSubscription> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCardSubscription> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardSubscription> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCardSubscription>(task);
        }

        #endregion

    }
}

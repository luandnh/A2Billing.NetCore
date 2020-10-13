using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcEpaymentLogExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcEpaymentLog GetByKey(this IQueryable<NesopsService.Data.Entities.CcEpaymentLog> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcEpaymentLog> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcEpaymentLog> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcEpaymentLog> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcEpaymentLog> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcEpaymentLog>(task);
        }

        #endregion

    }
}

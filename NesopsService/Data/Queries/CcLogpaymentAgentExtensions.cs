using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcLogpaymentAgentExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcLogpaymentAgent GetByKey(this IQueryable<NesopsService.Data.Entities.CcLogpaymentAgent> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcLogpaymentAgent> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcLogpaymentAgent> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcLogpaymentAgent> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcLogpaymentAgent> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcLogpaymentAgent>(task);
        }

        #endregion

    }
}

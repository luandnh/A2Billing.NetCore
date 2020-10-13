using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcLogrefillAgentExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcLogrefillAgent GetByKey(this IQueryable<NesopsService.Data.Entities.CcLogrefillAgent> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcLogrefillAgent> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcLogrefillAgent> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcLogrefillAgent> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcLogrefillAgent> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcLogrefillAgent>(task);
        }

        #endregion

    }
}

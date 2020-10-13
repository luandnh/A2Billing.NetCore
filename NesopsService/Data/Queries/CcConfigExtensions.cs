using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcConfigExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcConfig GetByKey(this IQueryable<NesopsService.Data.Entities.CcConfig> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcConfig> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcConfig> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcConfig> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcConfig> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcConfig>(task);
        }

        #endregion

    }
}

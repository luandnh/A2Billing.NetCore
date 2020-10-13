using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcSupportExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcSupport GetByKey(this IQueryable<NesopsService.Data.Entities.CcSupport> queryable, short id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcSupport> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcSupport> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcSupport> queryable, short id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcSupport> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcSupport>(task);
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcLogrefillExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcLogrefill GetByKey(this IQueryable<NesopsService.Data.Entities.CcLogrefill> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcLogrefill> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcLogrefill> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcLogrefill> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcLogrefill> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcLogrefill>(task);
        }

        #endregion

    }
}

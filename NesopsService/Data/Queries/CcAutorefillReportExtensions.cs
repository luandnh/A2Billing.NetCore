using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcAutorefillReportExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcAutorefillReport GetByKey(this IQueryable<NesopsService.Data.Entities.CcAutorefillReport> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcAutorefillReport> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcAutorefillReport> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcAutorefillReport> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcAutorefillReport> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcAutorefillReport>(task);
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcServiceReportExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcServiceReport GetByKey(this IQueryable<NesopsService.Data.Entities.CcServiceReport> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcServiceReport> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcServiceReport> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcServiceReport> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcServiceReport> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcServiceReport>(task);
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcAlarmReportExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcAlarmReport GetByKey(this IQueryable<NesopsService.Data.Entities.CcAlarmReport> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcAlarmReport> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcAlarmReport> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcAlarmReport> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcAlarmReport> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcAlarmReport>(task);
        }

        #endregion

    }
}

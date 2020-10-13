using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcSystemLogExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcSystemLog GetByKey(this IQueryable<NesopsService.Data.Entities.CcSystemLog> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcSystemLog> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcSystemLog> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcSystemLog> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcSystemLog> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcSystemLog>(task);
        }

        #endregion

    }
}

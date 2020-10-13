using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcStatusLogExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcStatusLog GetByKey(this IQueryable<NesopsService.Data.Entities.CcStatusLog> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcStatusLog> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcStatusLog> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcStatusLog> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcStatusLog> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcStatusLog>(task);
        }

        #endregion

    }
}

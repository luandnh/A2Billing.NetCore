using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCardHistoryExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCardHistory GetByKey(this IQueryable<NesopsService.Data.Entities.CcCardHistory> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardHistory> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCardHistory> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCardHistory> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardHistory> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCardHistory>(task);
        }

        #endregion

    }
}

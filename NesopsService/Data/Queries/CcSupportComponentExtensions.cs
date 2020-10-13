using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcSupportComponentExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcSupportComponent GetByKey(this IQueryable<NesopsService.Data.Entities.CcSupportComponent> queryable, short id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcSupportComponent> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcSupportComponent> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcSupportComponent> queryable, short id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcSupportComponent> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcSupportComponent>(task);
        }

        #endregion

    }
}

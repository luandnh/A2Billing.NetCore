using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcDidUseExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcDidUse GetByKey(this IQueryable<NesopsService.Data.Entities.CcDidUse> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcDidUse> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcDidUse> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcDidUse> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcDidUse> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcDidUse>(task);
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCardGroupExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCardGroup GetByKey(this IQueryable<NesopsService.Data.Entities.CcCardGroup> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardGroup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCardGroup> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCardGroup> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardGroup> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCardGroup>(task);
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcConfigGroupExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcConfigGroup GetByGroupTitle(this IQueryable<NesopsService.Data.Entities.CcConfigGroup> queryable, string groupTitle)
        {
            return queryable.FirstOrDefault(q => q.GroupTitle == groupTitle);
        }

        public static Task<NesopsService.Data.Entities.CcConfigGroup> GetByGroupTitleAsync(this IQueryable<NesopsService.Data.Entities.CcConfigGroup> queryable, string groupTitle)
        {
            return queryable.FirstOrDefaultAsync(q => q.GroupTitle == groupTitle);
        }

        public static NesopsService.Data.Entities.CcConfigGroup GetByKey(this IQueryable<NesopsService.Data.Entities.CcConfigGroup> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcConfigGroup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcConfigGroup> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcConfigGroup> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcConfigGroup> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcConfigGroup>(task);
        }

        #endregion

    }
}

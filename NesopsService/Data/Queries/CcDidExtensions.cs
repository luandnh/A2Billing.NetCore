using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcDidExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcDid GetByDid(this IQueryable<NesopsService.Data.Entities.CcDid> queryable, string did)
        {
            return queryable.FirstOrDefault(q => q.Did == did);
        }

        public static Task<NesopsService.Data.Entities.CcDid> GetByDidAsync(this IQueryable<NesopsService.Data.Entities.CcDid> queryable, string did)
        {
            return queryable.FirstOrDefaultAsync(q => q.Did == did);
        }

        public static NesopsService.Data.Entities.CcDid GetByKey(this IQueryable<NesopsService.Data.Entities.CcDid> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcDid> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcDid> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcDid> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcDid> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcDid>(task);
        }

        #endregion

    }
}

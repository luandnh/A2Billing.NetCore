using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcIso639Extensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcIso639 GetByKey(this IQueryable<NesopsService.Data.Entities.CcIso639> queryable, string code)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcIso639> dbSet)
                return dbSet.Find(code);

            return queryable.FirstOrDefault(q => q.Code == code);
        }

        public static ValueTask<NesopsService.Data.Entities.CcIso639> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcIso639> queryable, string code)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcIso639> dbSet)
                return dbSet.FindAsync(code);

            var task = queryable.FirstOrDefaultAsync(q => q.Code == code);
            return new ValueTask<NesopsService.Data.Entities.CcIso639>(task);
        }

        public static NesopsService.Data.Entities.CcIso639 GetByName(this IQueryable<NesopsService.Data.Entities.CcIso639> queryable, string name)
        {
            return queryable.FirstOrDefault(q => q.Name == name);
        }

        public static Task<NesopsService.Data.Entities.CcIso639> GetByNameAsync(this IQueryable<NesopsService.Data.Entities.CcIso639> queryable, string name)
        {
            return queryable.FirstOrDefaultAsync(q => q.Name == name);
        }

        #endregion

    }
}

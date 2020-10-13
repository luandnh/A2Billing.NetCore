using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcAgentExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcAgent GetByKey(this IQueryable<NesopsService.Data.Entities.CcAgent> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcAgent> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcAgent> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcAgent> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcAgent> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcAgent>(task);
        }

        public static NesopsService.Data.Entities.CcAgent GetByLogin(this IQueryable<NesopsService.Data.Entities.CcAgent> queryable, string login)
        {
            return queryable.FirstOrDefault(q => q.Login == login);
        }

        public static Task<NesopsService.Data.Entities.CcAgent> GetByLoginAsync(this IQueryable<NesopsService.Data.Entities.CcAgent> queryable, string login)
        {
            return queryable.FirstOrDefaultAsync(q => q.Login == login);
        }

        #endregion

    }
}

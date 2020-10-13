using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcUiAuthenExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcUiAuthen GetByLogin(this IQueryable<NesopsService.Data.Entities.CcUiAuthen> queryable, string login)
        {
            return queryable.FirstOrDefault(q => q.Login == login);
        }

        public static Task<NesopsService.Data.Entities.CcUiAuthen> GetByLoginAsync(this IQueryable<NesopsService.Data.Entities.CcUiAuthen> queryable, string login)
        {
            return queryable.FirstOrDefaultAsync(q => q.Login == login);
        }

        public static NesopsService.Data.Entities.CcUiAuthen GetByKey(this IQueryable<NesopsService.Data.Entities.CcUiAuthen> queryable, long userid)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcUiAuthen> dbSet)
                return dbSet.Find(userid);

            return queryable.FirstOrDefault(q => q.Userid == userid);
        }

        public static ValueTask<NesopsService.Data.Entities.CcUiAuthen> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcUiAuthen> queryable, long userid)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcUiAuthen> dbSet)
                return dbSet.FindAsync(userid);

            var task = queryable.FirstOrDefaultAsync(q => q.Userid == userid);
            return new ValueTask<NesopsService.Data.Entities.CcUiAuthen>(task);
        }

        #endregion

    }
}

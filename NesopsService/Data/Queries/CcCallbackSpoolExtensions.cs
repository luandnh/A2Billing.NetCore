using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCallbackSpoolExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCallbackSpool GetByKey(this IQueryable<NesopsService.Data.Entities.CcCallbackSpool> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCallbackSpool> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCallbackSpool> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCallbackSpool> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCallbackSpool> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCallbackSpool>(task);
        }

        public static NesopsService.Data.Entities.CcCallbackSpool GetByUniqueid(this IQueryable<NesopsService.Data.Entities.CcCallbackSpool> queryable, string uniqueid)
        {
            return queryable.FirstOrDefault(q => (q.Uniqueid == uniqueid || (uniqueid == null && q.Uniqueid == null)));
        }

        public static Task<NesopsService.Data.Entities.CcCallbackSpool> GetByUniqueidAsync(this IQueryable<NesopsService.Data.Entities.CcCallbackSpool> queryable, string uniqueid)
        {
            return queryable.FirstOrDefaultAsync(q => (q.Uniqueid == uniqueid || (uniqueid == null && q.Uniqueid == null)));
        }

        #endregion

    }
}

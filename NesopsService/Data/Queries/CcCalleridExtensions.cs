using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCalleridExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCallerid GetByCid(this IQueryable<NesopsService.Data.Entities.CcCallerid> queryable, string cid)
        {
            return queryable.FirstOrDefault(q => q.Cid == cid);
        }

        public static Task<NesopsService.Data.Entities.CcCallerid> GetByCidAsync(this IQueryable<NesopsService.Data.Entities.CcCallerid> queryable, string cid)
        {
            return queryable.FirstOrDefaultAsync(q => q.Cid == cid);
        }

        public static NesopsService.Data.Entities.CcCallerid GetByKey(this IQueryable<NesopsService.Data.Entities.CcCallerid> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCallerid> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCallerid> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCallerid> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCallerid> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCallerid>(task);
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcServerManagerExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcServerManager GetByKey(this IQueryable<NesopsService.Data.Entities.CcServerManager> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcServerManager> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcServerManager> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcServerManager> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcServerManager> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcServerManager>(task);
        }

        #endregion

    }
}

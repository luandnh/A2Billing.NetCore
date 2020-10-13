using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcDidDestinationExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcDidDestination GetByKey(this IQueryable<NesopsService.Data.Entities.CcDidDestination> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcDidDestination> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcDidDestination> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcDidDestination> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcDidDestination> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcDidDestination>(task);
        }

        #endregion

    }
}

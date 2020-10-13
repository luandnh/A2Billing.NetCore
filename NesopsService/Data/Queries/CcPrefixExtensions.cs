using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcPrefixExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.CcPrefix> ByDestination(this IQueryable<NesopsService.Data.Entities.CcPrefix> queryable, string destination)
        {
            return queryable.Where(q => q.Destination == destination);
        }

        public static NesopsService.Data.Entities.CcPrefix GetByKey(this IQueryable<NesopsService.Data.Entities.CcPrefix> queryable, long prefix)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPrefix> dbSet)
                return dbSet.Find(prefix);

            return queryable.FirstOrDefault(q => q.Prefix == prefix);
        }

        public static ValueTask<NesopsService.Data.Entities.CcPrefix> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcPrefix> queryable, long prefix)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPrefix> dbSet)
                return dbSet.FindAsync(prefix);

            var task = queryable.FirstOrDefaultAsync(q => q.Prefix == prefix);
            return new ValueTask<NesopsService.Data.Entities.CcPrefix>(task);
        }

        #endregion

    }
}

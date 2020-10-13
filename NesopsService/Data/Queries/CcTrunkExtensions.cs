using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcTrunkExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcTrunk GetByKey(this IQueryable<NesopsService.Data.Entities.CcTrunk> queryable, int idTrunk)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTrunk> dbSet)
                return dbSet.Find(idTrunk);

            return queryable.FirstOrDefault(q => q.IdTrunk == idTrunk);
        }

        public static ValueTask<NesopsService.Data.Entities.CcTrunk> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcTrunk> queryable, int idTrunk)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTrunk> dbSet)
                return dbSet.FindAsync(idTrunk);

            var task = queryable.FirstOrDefaultAsync(q => q.IdTrunk == idTrunk);
            return new ValueTask<NesopsService.Data.Entities.CcTrunk>(task);
        }

        #endregion

    }
}

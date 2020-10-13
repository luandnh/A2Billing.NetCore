using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcOutboundCidGroupExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcOutboundCidGroup GetByKey(this IQueryable<NesopsService.Data.Entities.CcOutboundCidGroup> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcOutboundCidGroup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcOutboundCidGroup> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcOutboundCidGroup> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcOutboundCidGroup> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcOutboundCidGroup>(task);
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcOutboundCidListExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcOutboundCidList GetByKey(this IQueryable<NesopsService.Data.Entities.CcOutboundCidList> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcOutboundCidList> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcOutboundCidList> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcOutboundCidList> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcOutboundCidList> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcOutboundCidList>(task);
        }

        #endregion

    }
}

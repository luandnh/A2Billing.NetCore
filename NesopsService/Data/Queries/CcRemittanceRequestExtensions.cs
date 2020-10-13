using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcRemittanceRequestExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcRemittanceRequest GetByKey(this IQueryable<NesopsService.Data.Entities.CcRemittanceRequest> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcRemittanceRequest> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcRemittanceRequest> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcRemittanceRequest> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcRemittanceRequest> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcRemittanceRequest>(task);
        }

        #endregion

    }
}

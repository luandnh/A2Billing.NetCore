using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcRatecardExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.CcRatecard> ByDialprefix(this IQueryable<NesopsService.Data.Entities.CcRatecard> queryable, string dialprefix)
        {
            return queryable.Where(q => q.Dialprefix == dialprefix);
        }

        public static NesopsService.Data.Entities.CcRatecard GetByKey(this IQueryable<NesopsService.Data.Entities.CcRatecard> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcRatecard> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcRatecard> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcRatecard> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcRatecard> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcRatecard>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.CcRatecard> ByIdtariffplan(this IQueryable<NesopsService.Data.Entities.CcRatecard> queryable, int idtariffplan)
        {
            return queryable.Where(q => q.Idtariffplan == idtariffplan);
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcTariffgroupExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcTariffgroup GetByKey(this IQueryable<NesopsService.Data.Entities.CcTariffgroup> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTariffgroup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcTariffgroup> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcTariffgroup> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTariffgroup> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcTariffgroup>(task);
        }

        #endregion

    }
}

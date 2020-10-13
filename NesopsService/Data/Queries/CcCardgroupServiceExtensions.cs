using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCardgroupServiceExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCardgroupService GetByKey(this IQueryable<NesopsService.Data.Entities.CcCardgroupService> queryable, int idCardGroup, int idService)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardgroupService> dbSet)
                return dbSet.Find(idCardGroup, idService);

            return queryable.FirstOrDefault(q => q.IdCardGroup == idCardGroup
                && q.IdService == idService);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCardgroupService> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCardgroupService> queryable, int idCardGroup, int idService)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardgroupService> dbSet)
                return dbSet.FindAsync(idCardGroup, idService);

            var task = queryable.FirstOrDefaultAsync(q => q.IdCardGroup == idCardGroup
                && q.IdService == idService);
            return new ValueTask<NesopsService.Data.Entities.CcCardgroupService>(task);
        }

        #endregion

    }
}

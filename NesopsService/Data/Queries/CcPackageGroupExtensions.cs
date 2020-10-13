using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcPackageGroupExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcPackageGroup GetByKey(this IQueryable<NesopsService.Data.Entities.CcPackageGroup> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPackageGroup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcPackageGroup> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcPackageGroup> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPackageGroup> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcPackageGroup>(task);
        }

        #endregion

    }
}

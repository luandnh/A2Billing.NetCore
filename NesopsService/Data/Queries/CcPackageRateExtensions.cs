using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcPackageRateExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcPackageRate GetByKey(this IQueryable<NesopsService.Data.Entities.CcPackageRate> queryable, int packageId, int rateId)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPackageRate> dbSet)
                return dbSet.Find(packageId, rateId);

            return queryable.FirstOrDefault(q => q.PackageId == packageId
                && q.RateId == rateId);
        }

        public static ValueTask<NesopsService.Data.Entities.CcPackageRate> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcPackageRate> queryable, int packageId, int rateId)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPackageRate> dbSet)
                return dbSet.FindAsync(packageId, rateId);

            var task = queryable.FirstOrDefaultAsync(q => q.PackageId == packageId
                && q.RateId == rateId);
            return new ValueTask<NesopsService.Data.Entities.CcPackageRate>(task);
        }

        #endregion

    }
}

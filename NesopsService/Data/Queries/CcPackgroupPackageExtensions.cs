using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcPackgroupPackageExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcPackgroupPackage GetByKey(this IQueryable<NesopsService.Data.Entities.CcPackgroupPackage> queryable, int packagegroupId, int packageId)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPackgroupPackage> dbSet)
                return dbSet.Find(packagegroupId, packageId);

            return queryable.FirstOrDefault(q => q.PackagegroupId == packagegroupId
                && q.PackageId == packageId);
        }

        public static ValueTask<NesopsService.Data.Entities.CcPackgroupPackage> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcPackgroupPackage> queryable, int packagegroupId, int packageId)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPackgroupPackage> dbSet)
                return dbSet.FindAsync(packagegroupId, packageId);

            var task = queryable.FirstOrDefaultAsync(q => q.PackagegroupId == packagegroupId
                && q.PackageId == packageId);
            return new ValueTask<NesopsService.Data.Entities.CcPackgroupPackage>(task);
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcConfigurationExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcConfiguration GetByKey(this IQueryable<NesopsService.Data.Entities.CcConfiguration> queryable, int configurationId)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcConfiguration> dbSet)
                return dbSet.Find(configurationId);

            return queryable.FirstOrDefault(q => q.ConfigurationId == configurationId);
        }

        public static ValueTask<NesopsService.Data.Entities.CcConfiguration> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcConfiguration> queryable, int configurationId)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcConfiguration> dbSet)
                return dbSet.FindAsync(configurationId);

            var task = queryable.FirstOrDefaultAsync(q => q.ConfigurationId == configurationId);
            return new ValueTask<NesopsService.Data.Entities.CcConfiguration>(task);
        }

        #endregion

    }
}

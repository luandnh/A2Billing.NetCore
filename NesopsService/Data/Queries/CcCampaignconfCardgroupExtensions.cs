using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCampaignconfCardgroupExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCampaignconfCardgroup GetByKey(this IQueryable<NesopsService.Data.Entities.CcCampaignconfCardgroup> queryable, int idCampaignConfig, int idCardGroup)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCampaignconfCardgroup> dbSet)
                return dbSet.Find(idCampaignConfig, idCardGroup);

            return queryable.FirstOrDefault(q => q.IdCampaignConfig == idCampaignConfig
                && q.IdCardGroup == idCardGroup);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCampaignconfCardgroup> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCampaignconfCardgroup> queryable, int idCampaignConfig, int idCardGroup)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCampaignconfCardgroup> dbSet)
                return dbSet.FindAsync(idCampaignConfig, idCardGroup);

            var task = queryable.FirstOrDefaultAsync(q => q.IdCampaignConfig == idCampaignConfig
                && q.IdCardGroup == idCardGroup);
            return new ValueTask<NesopsService.Data.Entities.CcCampaignconfCardgroup>(task);
        }

        #endregion

    }
}

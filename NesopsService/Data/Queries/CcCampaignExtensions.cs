using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCampaignExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCampaign GetByKey(this IQueryable<NesopsService.Data.Entities.CcCampaign> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCampaign> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCampaign> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCampaign> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCampaign> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCampaign>(task);
        }

        public static NesopsService.Data.Entities.CcCampaign GetByName(this IQueryable<NesopsService.Data.Entities.CcCampaign> queryable, string name)
        {
            return queryable.FirstOrDefault(q => q.Name == name);
        }

        public static Task<NesopsService.Data.Entities.CcCampaign> GetByNameAsync(this IQueryable<NesopsService.Data.Entities.CcCampaign> queryable, string name)
        {
            return queryable.FirstOrDefaultAsync(q => q.Name == name);
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCampaignPhonebookExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCampaignPhonebook GetByKey(this IQueryable<NesopsService.Data.Entities.CcCampaignPhonebook> queryable, int idCampaign, int idPhonebook)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCampaignPhonebook> dbSet)
                return dbSet.Find(idCampaign, idPhonebook);

            return queryable.FirstOrDefault(q => q.IdCampaign == idCampaign
                && q.IdPhonebook == idPhonebook);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCampaignPhonebook> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCampaignPhonebook> queryable, int idCampaign, int idPhonebook)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCampaignPhonebook> dbSet)
                return dbSet.FindAsync(idCampaign, idPhonebook);

            var task = queryable.FirstOrDefaultAsync(q => q.IdCampaign == idCampaign
                && q.IdPhonebook == idPhonebook);
            return new ValueTask<NesopsService.Data.Entities.CcCampaignPhonebook>(task);
        }

        #endregion

    }
}

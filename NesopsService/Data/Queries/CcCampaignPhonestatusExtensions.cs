using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCampaignPhonestatusExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCampaignPhonestatus GetByKey(this IQueryable<NesopsService.Data.Entities.CcCampaignPhonestatus> queryable, long idPhonenumber, int idCampaign)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCampaignPhonestatus> dbSet)
                return dbSet.Find(idPhonenumber, idCampaign);

            return queryable.FirstOrDefault(q => q.IdPhonenumber == idPhonenumber
                && q.IdCampaign == idCampaign);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCampaignPhonestatus> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCampaignPhonestatus> queryable, long idPhonenumber, int idCampaign)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCampaignPhonestatus> dbSet)
                return dbSet.FindAsync(idPhonenumber, idCampaign);

            var task = queryable.FirstOrDefaultAsync(q => q.IdPhonenumber == idPhonenumber
                && q.IdCampaign == idCampaign);
            return new ValueTask<NesopsService.Data.Entities.CcCampaignPhonestatus>(task);
        }

        #endregion

    }
}

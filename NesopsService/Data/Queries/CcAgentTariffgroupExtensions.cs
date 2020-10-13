using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcAgentTariffgroupExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcAgentTariffgroup GetByKey(this IQueryable<NesopsService.Data.Entities.CcAgentTariffgroup> queryable, long idAgent, int idTariffgroup)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcAgentTariffgroup> dbSet)
                return dbSet.Find(idAgent, idTariffgroup);

            return queryable.FirstOrDefault(q => q.IdAgent == idAgent
                && q.IdTariffgroup == idTariffgroup);
        }

        public static ValueTask<NesopsService.Data.Entities.CcAgentTariffgroup> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcAgentTariffgroup> queryable, long idAgent, int idTariffgroup)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcAgentTariffgroup> dbSet)
                return dbSet.FindAsync(idAgent, idTariffgroup);

            var task = queryable.FirstOrDefaultAsync(q => q.IdAgent == idAgent
                && q.IdTariffgroup == idTariffgroup);
            return new ValueTask<NesopsService.Data.Entities.CcAgentTariffgroup>(task);
        }

        #endregion

    }
}

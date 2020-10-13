using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcTariffgroupPlanExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcTariffgroupPlan GetByKey(this IQueryable<NesopsService.Data.Entities.CcTariffgroupPlan> queryable, int idtariffgroup, int idtariffplan)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTariffgroupPlan> dbSet)
                return dbSet.Find(idtariffgroup, idtariffplan);

            return queryable.FirstOrDefault(q => q.Idtariffgroup == idtariffgroup
                && q.Idtariffplan == idtariffplan);
        }

        public static ValueTask<NesopsService.Data.Entities.CcTariffgroupPlan> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcTariffgroupPlan> queryable, int idtariffgroup, int idtariffplan)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTariffgroupPlan> dbSet)
                return dbSet.FindAsync(idtariffgroup, idtariffplan);

            var task = queryable.FirstOrDefaultAsync(q => q.Idtariffgroup == idtariffgroup
                && q.Idtariffplan == idtariffplan);
            return new ValueTask<NesopsService.Data.Entities.CcTariffgroupPlan>(task);
        }

        #endregion

    }
}

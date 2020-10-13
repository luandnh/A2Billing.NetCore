using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcChargeExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.CcCharge> ByCreationdate(this IQueryable<NesopsService.Data.Entities.CcCharge> queryable, DateTime creationdate)
        {
            return queryable.Where(q => q.Creationdate == creationdate);
        }

        public static NesopsService.Data.Entities.CcCharge GetByKey(this IQueryable<NesopsService.Data.Entities.CcCharge> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCharge> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCharge> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCharge> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCharge> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCharge>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.CcCharge> ByIdCcCard(this IQueryable<NesopsService.Data.Entities.CcCharge> queryable, long idCcCard)
        {
            return queryable.Where(q => q.IdCcCard == idCcCard);
        }

        #endregion

    }
}

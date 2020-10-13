using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCardPackageOfferExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.CcCardPackageOffer> ByDateConsumption(this IQueryable<NesopsService.Data.Entities.CcCardPackageOffer> queryable, DateTime dateConsumption)
        {
            return queryable.Where(q => q.DateConsumption == dateConsumption);
        }

        public static NesopsService.Data.Entities.CcCardPackageOffer GetByKey(this IQueryable<NesopsService.Data.Entities.CcCardPackageOffer> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardPackageOffer> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCardPackageOffer> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCardPackageOffer> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardPackageOffer> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCardPackageOffer>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.CcCardPackageOffer> ByIdCcCard(this IQueryable<NesopsService.Data.Entities.CcCardPackageOffer> queryable, long idCcCard)
        {
            return queryable.Where(q => q.IdCcCard == idCcCard);
        }

        public static IQueryable<NesopsService.Data.Entities.CcCardPackageOffer> ByIdCcPackageOffer(this IQueryable<NesopsService.Data.Entities.CcCardPackageOffer> queryable, long idCcPackageOffer)
        {
            return queryable.Where(q => q.IdCcPackageOffer == idCcPackageOffer);
        }

        #endregion

    }
}

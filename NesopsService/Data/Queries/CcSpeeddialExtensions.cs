using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcSpeeddialExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcSpeeddial GetByKey(this IQueryable<NesopsService.Data.Entities.CcSpeeddial> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcSpeeddial> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcSpeeddial> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcSpeeddial> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcSpeeddial> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcSpeeddial>(task);
        }

        public static NesopsService.Data.Entities.CcSpeeddial GetByIdCcCardSpeeddial(this IQueryable<NesopsService.Data.Entities.CcSpeeddial> queryable, long idCcCard, int? speeddial)
        {
            return queryable.FirstOrDefault(q => q.IdCcCard == idCcCard
                && (q.Speeddial == speeddial || (speeddial == null && q.Speeddial == null)));
        }

        public static Task<NesopsService.Data.Entities.CcSpeeddial> GetByIdCcCardSpeeddialAsync(this IQueryable<NesopsService.Data.Entities.CcSpeeddial> queryable, long idCcCard, int? speeddial)
        {
            return queryable.FirstOrDefaultAsync(q => q.IdCcCard == idCcCard
                && (q.Speeddial == speeddial || (speeddial == null && q.Speeddial == null)));
        }

        #endregion

    }
}

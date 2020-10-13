using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcContactExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.CcContact> ByCardId(this IQueryable<NesopsService.Data.Entities.CcContact> queryable, long cardId)
        {
            return queryable.Where(q => q.CardId == cardId);
        }

        public static NesopsService.Data.Entities.CcContact GetByKey(this IQueryable<NesopsService.Data.Entities.CcContact> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcContact> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcContact> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcContact> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcContact> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcContact>(task);
        }

        #endregion

    }
}

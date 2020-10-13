using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcRestrictedPhonenumberExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcRestrictedPhonenumber GetByKey(this IQueryable<NesopsService.Data.Entities.CcRestrictedPhonenumber> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcRestrictedPhonenumber> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcRestrictedPhonenumber> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcRestrictedPhonenumber> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcRestrictedPhonenumber> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcRestrictedPhonenumber>(task);
        }

        #endregion

    }
}

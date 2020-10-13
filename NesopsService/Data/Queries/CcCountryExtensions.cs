using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCountryExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCountry GetByKey(this IQueryable<NesopsService.Data.Entities.CcCountry> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCountry> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCountry> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCountry> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCountry> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCountry>(task);
        }

        #endregion

    }
}

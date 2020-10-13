using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcProviderExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcProvider GetByKey(this IQueryable<NesopsService.Data.Entities.CcProvider> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcProvider> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcProvider> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcProvider> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcProvider> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcProvider>(task);
        }

        public static NesopsService.Data.Entities.CcProvider GetByProviderName(this IQueryable<NesopsService.Data.Entities.CcProvider> queryable, string providerName)
        {
            return queryable.FirstOrDefault(q => q.ProviderName == providerName);
        }

        public static Task<NesopsService.Data.Entities.CcProvider> GetByProviderNameAsync(this IQueryable<NesopsService.Data.Entities.CcProvider> queryable, string providerName)
        {
            return queryable.FirstOrDefaultAsync(q => q.ProviderName == providerName);
        }

        #endregion

    }
}

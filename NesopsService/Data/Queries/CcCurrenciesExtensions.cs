using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCurrenciesExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcCurrencies GetByCurrency(this IQueryable<NesopsService.Data.Entities.CcCurrencies> queryable, string currency)
        {
            return queryable.FirstOrDefault(q => q.Currency == currency);
        }

        public static Task<NesopsService.Data.Entities.CcCurrencies> GetByCurrencyAsync(this IQueryable<NesopsService.Data.Entities.CcCurrencies> queryable, string currency)
        {
            return queryable.FirstOrDefaultAsync(q => q.Currency == currency);
        }

        public static NesopsService.Data.Entities.CcCurrencies GetByKey(this IQueryable<NesopsService.Data.Entities.CcCurrencies> queryable, ushort id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCurrencies> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCurrencies> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCurrencies> queryable, ushort id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCurrencies> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCurrencies>(task);
        }

        #endregion

    }
}

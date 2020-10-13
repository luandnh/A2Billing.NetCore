using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcInvoiceConfExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcInvoiceConf GetByKey(this IQueryable<NesopsService.Data.Entities.CcInvoiceConf> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcInvoiceConf> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcInvoiceConf> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcInvoiceConf> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcInvoiceConf> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcInvoiceConf>(task);
        }

        public static NesopsService.Data.Entities.CcInvoiceConf GetByKeyVal(this IQueryable<NesopsService.Data.Entities.CcInvoiceConf> queryable, string keyVal)
        {
            return queryable.FirstOrDefault(q => q.KeyVal == keyVal);
        }

        public static Task<NesopsService.Data.Entities.CcInvoiceConf> GetByKeyValAsync(this IQueryable<NesopsService.Data.Entities.CcInvoiceConf> queryable, string keyVal)
        {
            return queryable.FirstOrDefaultAsync(q => q.KeyVal == keyVal);
        }

        #endregion

    }
}

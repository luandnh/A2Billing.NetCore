using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcBillingCustomerExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcBillingCustomer GetByKey(this IQueryable<NesopsService.Data.Entities.CcBillingCustomer> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcBillingCustomer> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcBillingCustomer> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcBillingCustomer> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcBillingCustomer> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcBillingCustomer>(task);
        }

        #endregion

    }
}

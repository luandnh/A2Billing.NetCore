using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcPaymentMethodsExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcPaymentMethods GetByKey(this IQueryable<NesopsService.Data.Entities.CcPaymentMethods> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPaymentMethods> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcPaymentMethods> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcPaymentMethods> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPaymentMethods> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcPaymentMethods>(task);
        }

        #endregion

    }
}

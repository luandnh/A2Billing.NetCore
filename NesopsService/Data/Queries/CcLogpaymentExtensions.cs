using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcLogpaymentExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcLogpayment GetByKey(this IQueryable<NesopsService.Data.Entities.CcLogpayment> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcLogpayment> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcLogpayment> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcLogpayment> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcLogpayment> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcLogpayment>(task);
        }

        #endregion

    }
}

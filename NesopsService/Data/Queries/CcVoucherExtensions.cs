using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcVoucherExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcVoucher GetByKey(this IQueryable<NesopsService.Data.Entities.CcVoucher> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcVoucher> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcVoucher> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcVoucher> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcVoucher> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcVoucher>(task);
        }

        public static NesopsService.Data.Entities.CcVoucher GetByVoucher(this IQueryable<NesopsService.Data.Entities.CcVoucher> queryable, string voucher)
        {
            return queryable.FirstOrDefault(q => q.Voucher == voucher);
        }

        public static Task<NesopsService.Data.Entities.CcVoucher> GetByVoucherAsync(this IQueryable<NesopsService.Data.Entities.CcVoucher> queryable, string voucher)
        {
            return queryable.FirstOrDefaultAsync(q => q.Voucher == voucher);
        }

        #endregion

    }
}

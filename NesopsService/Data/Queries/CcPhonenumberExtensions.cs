using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcPhonenumberExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcPhonenumber GetByKey(this IQueryable<NesopsService.Data.Entities.CcPhonenumber> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPhonenumber> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcPhonenumber> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcPhonenumber> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPhonenumber> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcPhonenumber>(task);
        }

        #endregion

    }
}

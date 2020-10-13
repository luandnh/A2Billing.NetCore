using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcPhonebookExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcPhonebook GetByKey(this IQueryable<NesopsService.Data.Entities.CcPhonebook> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPhonebook> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcPhonebook> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcPhonebook> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcPhonebook> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcPhonebook>(task);
        }

        #endregion

    }
}

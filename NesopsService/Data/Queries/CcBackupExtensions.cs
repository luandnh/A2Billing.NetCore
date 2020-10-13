using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcBackupExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcBackup GetByKey(this IQueryable<NesopsService.Data.Entities.CcBackup> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcBackup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcBackup> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcBackup> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcBackup> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcBackup>(task);
        }

        public static NesopsService.Data.Entities.CcBackup GetByName(this IQueryable<NesopsService.Data.Entities.CcBackup> queryable, string name)
        {
            return queryable.FirstOrDefault(q => q.Name == name);
        }

        public static Task<NesopsService.Data.Entities.CcBackup> GetByNameAsync(this IQueryable<NesopsService.Data.Entities.CcBackup> queryable, string name)
        {
            return queryable.FirstOrDefaultAsync(q => q.Name == name);
        }

        #endregion

    }
}

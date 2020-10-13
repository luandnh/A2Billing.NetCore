using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCardArchiveExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.CcCardArchive> ByCreationdate(this IQueryable<NesopsService.Data.Entities.CcCardArchive> queryable, DateTime creationdate)
        {
            return queryable.Where(q => q.Creationdate == creationdate);
        }

        public static NesopsService.Data.Entities.CcCardArchive GetByKey(this IQueryable<NesopsService.Data.Entities.CcCardArchive> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardArchive> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCardArchive> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCardArchive> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCardArchive> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCardArchive>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.CcCardArchive> ByUsername(this IQueryable<NesopsService.Data.Entities.CcCardArchive> queryable, string username)
        {
            return queryable.Where(q => q.Username == username);
        }

        #endregion

    }
}

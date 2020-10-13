using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCallArchiveExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.CcCallArchive> ByCalledstation(this IQueryable<NesopsService.Data.Entities.CcCallArchive> queryable, string calledstation)
        {
            return queryable.Where(q => q.Calledstation == calledstation);
        }

        public static NesopsService.Data.Entities.CcCallArchive GetByKey(this IQueryable<NesopsService.Data.Entities.CcCallArchive> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCallArchive> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCallArchive> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCallArchive> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCallArchive> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCallArchive>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.CcCallArchive> ByStarttime(this IQueryable<NesopsService.Data.Entities.CcCallArchive> queryable, DateTime starttime)
        {
            return queryable.Where(q => q.Starttime == starttime);
        }

        public static IQueryable<NesopsService.Data.Entities.CcCallArchive> ByTerminatecauseid(this IQueryable<NesopsService.Data.Entities.CcCallArchive> queryable, int? terminatecauseid)
        {
            return queryable.Where(q => (q.Terminatecauseid == terminatecauseid || (terminatecauseid == null && q.Terminatecauseid == null)));
        }

        #endregion

    }
}

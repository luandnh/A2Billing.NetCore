using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCallExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.CcCall> ByCalledstation(this IQueryable<NesopsService.Data.Entities.CcCall> queryable, string calledstation)
        {
            return queryable.Where(q => q.Calledstation == calledstation);
        }

        public static NesopsService.Data.Entities.CcCall GetByKey(this IQueryable<NesopsService.Data.Entities.CcCall> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCall> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCall> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCall> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCall> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCall>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.CcCall> ByStarttime(this IQueryable<NesopsService.Data.Entities.CcCall> queryable, DateTime starttime)
        {
            return queryable.Where(q => q.Starttime == starttime);
        }

        public static IQueryable<NesopsService.Data.Entities.CcCall> ByTerminatecauseid(this IQueryable<NesopsService.Data.Entities.CcCall> queryable, int? terminatecauseid)
        {
            return queryable.Where(q => (q.Terminatecauseid == terminatecauseid || (terminatecauseid == null && q.Terminatecauseid == null)));
        }

        #endregion

    }
}

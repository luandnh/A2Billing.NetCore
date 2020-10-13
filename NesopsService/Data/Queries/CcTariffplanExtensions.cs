using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcTariffplanExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcTariffplan GetByKey(this IQueryable<NesopsService.Data.Entities.CcTariffplan> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTariffplan> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcTariffplan> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcTariffplan> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTariffplan> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcTariffplan>(task);
        }

        public static NesopsService.Data.Entities.CcTariffplan GetByIduserTariffname(this IQueryable<NesopsService.Data.Entities.CcTariffplan> queryable, int iduser, string tariffname)
        {
            return queryable.FirstOrDefault(q => q.Iduser == iduser
                && q.Tariffname == tariffname);
        }

        public static Task<NesopsService.Data.Entities.CcTariffplan> GetByIduserTariffnameAsync(this IQueryable<NesopsService.Data.Entities.CcTariffplan> queryable, int iduser, string tariffname)
        {
            return queryable.FirstOrDefaultAsync(q => q.Iduser == iduser
                && q.Tariffname == tariffname);
        }

        #endregion

    }
}

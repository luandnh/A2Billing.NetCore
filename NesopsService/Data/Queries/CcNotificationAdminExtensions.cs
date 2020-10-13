using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcNotificationAdminExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcNotificationAdmin GetByKey(this IQueryable<NesopsService.Data.Entities.CcNotificationAdmin> queryable, long idNotification, int idAdmin)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcNotificationAdmin> dbSet)
                return dbSet.Find(idNotification, idAdmin);

            return queryable.FirstOrDefault(q => q.IdNotification == idNotification
                && q.IdAdmin == idAdmin);
        }

        public static ValueTask<NesopsService.Data.Entities.CcNotificationAdmin> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcNotificationAdmin> queryable, long idNotification, int idAdmin)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcNotificationAdmin> dbSet)
                return dbSet.FindAsync(idNotification, idAdmin);

            var task = queryable.FirstOrDefaultAsync(q => q.IdNotification == idNotification
                && q.IdAdmin == idAdmin);
            return new ValueTask<NesopsService.Data.Entities.CcNotificationAdmin>(task);
        }

        #endregion

    }
}

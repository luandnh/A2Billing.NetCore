using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcTicketCommentExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcTicketComment GetByKey(this IQueryable<NesopsService.Data.Entities.CcTicketComment> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTicketComment> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcTicketComment> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcTicketComment> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTicketComment> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcTicketComment>(task);
        }

        #endregion

    }
}

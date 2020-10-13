using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcCardExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.CcCard> ByCreationdate(this IQueryable<NesopsService.Data.Entities.CcCard> queryable, DateTime creationdate)
        {
            return queryable.Where(q => q.Creationdate == creationdate);
        }

        public static NesopsService.Data.Entities.CcCard GetByKey(this IQueryable<NesopsService.Data.Entities.CcCard> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCard> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcCard> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcCard> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcCard> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcCard>(task);
        }

        public static NesopsService.Data.Entities.CcCard GetByUseralias(this IQueryable<NesopsService.Data.Entities.CcCard> queryable, string useralias)
        {
            return queryable.FirstOrDefault(q => q.Useralias == useralias);
        }

        public static Task<NesopsService.Data.Entities.CcCard> GetByUseraliasAsync(this IQueryable<NesopsService.Data.Entities.CcCard> queryable, string useralias)
        {
            return queryable.FirstOrDefaultAsync(q => q.Useralias == useralias);
        }

        public static NesopsService.Data.Entities.CcCard GetByUsername(this IQueryable<NesopsService.Data.Entities.CcCard> queryable, string username)
        {
            return queryable.FirstOrDefault(q => q.Username == username);
        }

        public static Task<NesopsService.Data.Entities.CcCard> GetByUsernameAsync(this IQueryable<NesopsService.Data.Entities.CcCard> queryable, string username)
        {
            return queryable.FirstOrDefaultAsync(q => q.Username == username);
        }

        #endregion

    }
}

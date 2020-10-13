using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcAgentSignupExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcAgentSignup GetByCode(this IQueryable<NesopsService.Data.Entities.CcAgentSignup> queryable, string code)
        {
            return queryable.FirstOrDefault(q => q.Code == code);
        }

        public static Task<NesopsService.Data.Entities.CcAgentSignup> GetByCodeAsync(this IQueryable<NesopsService.Data.Entities.CcAgentSignup> queryable, string code)
        {
            return queryable.FirstOrDefaultAsync(q => q.Code == code);
        }

        public static NesopsService.Data.Entities.CcAgentSignup GetByKey(this IQueryable<NesopsService.Data.Entities.CcAgentSignup> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcAgentSignup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcAgentSignup> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcAgentSignup> queryable, long id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcAgentSignup> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcAgentSignup>(task);
        }

        #endregion

    }
}

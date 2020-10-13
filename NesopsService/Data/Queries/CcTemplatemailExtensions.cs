using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcTemplatemailExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.CcTemplatemail GetByKey(this IQueryable<NesopsService.Data.Entities.CcTemplatemail> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTemplatemail> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcTemplatemail> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcTemplatemail> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcTemplatemail> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcTemplatemail>(task);
        }

        public static NesopsService.Data.Entities.CcTemplatemail GetByMailtypeIdLanguage(this IQueryable<NesopsService.Data.Entities.CcTemplatemail> queryable, string mailtype, string idLanguage)
        {
            return queryable.FirstOrDefault(q => (q.Mailtype == mailtype || (mailtype == null && q.Mailtype == null))
                && q.IdLanguage == idLanguage);
        }

        public static Task<NesopsService.Data.Entities.CcTemplatemail> GetByMailtypeIdLanguageAsync(this IQueryable<NesopsService.Data.Entities.CcTemplatemail> queryable, string mailtype, string idLanguage)
        {
            return queryable.FirstOrDefaultAsync(q => (q.Mailtype == mailtype || (mailtype == null && q.Mailtype == null))
                && q.IdLanguage == idLanguage);
        }

        #endregion

    }
}

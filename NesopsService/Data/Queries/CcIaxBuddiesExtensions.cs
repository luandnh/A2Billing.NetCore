using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class CcIaxBuddiesExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.CcIaxBuddies> ByHost(this IQueryable<NesopsService.Data.Entities.CcIaxBuddies> queryable, string host)
        {
            return queryable.Where(q => q.Host == host);
        }

        public static IQueryable<NesopsService.Data.Entities.CcIaxBuddies> ByHostPort(this IQueryable<NesopsService.Data.Entities.CcIaxBuddies> queryable, string host, string port)
        {
            return queryable.Where(q => q.Host == host
                && q.Port == port);
        }

        public static NesopsService.Data.Entities.CcIaxBuddies GetByKey(this IQueryable<NesopsService.Data.Entities.CcIaxBuddies> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcIaxBuddies> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.CcIaxBuddies> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.CcIaxBuddies> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.CcIaxBuddies> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.CcIaxBuddies>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.CcIaxBuddies> ByIpaddr(this IQueryable<NesopsService.Data.Entities.CcIaxBuddies> queryable, string ipaddr)
        {
            return queryable.Where(q => q.Ipaddr == ipaddr);
        }

        public static IQueryable<NesopsService.Data.Entities.CcIaxBuddies> ByIpaddrPort(this IQueryable<NesopsService.Data.Entities.CcIaxBuddies> queryable, string ipaddr, string port)
        {
            return queryable.Where(q => q.Ipaddr == ipaddr
                && q.Port == port);
        }

        public static NesopsService.Data.Entities.CcIaxBuddies GetByName(this IQueryable<NesopsService.Data.Entities.CcIaxBuddies> queryable, string name)
        {
            return queryable.FirstOrDefault(q => q.Name == name);
        }

        public static Task<NesopsService.Data.Entities.CcIaxBuddies> GetByNameAsync(this IQueryable<NesopsService.Data.Entities.CcIaxBuddies> queryable, string name)
        {
            return queryable.FirstOrDefaultAsync(q => q.Name == name);
        }

        public static IQueryable<NesopsService.Data.Entities.CcIaxBuddies> ByNameHost(this IQueryable<NesopsService.Data.Entities.CcIaxBuddies> queryable, string name, string host)
        {
            return queryable.Where(q => q.Name == name
                && q.Host == host);
        }

        public static IQueryable<NesopsService.Data.Entities.CcIaxBuddies> ByNameIpaddrPort(this IQueryable<NesopsService.Data.Entities.CcIaxBuddies> queryable, string name, string ipaddr, string port)
        {
            return queryable.Where(q => q.Name == name
                && q.Ipaddr == ipaddr
                    && q.Port == port);
            }

            public static IQueryable<NesopsService.Data.Entities.CcIaxBuddies> ByPort(this IQueryable<NesopsService.Data.Entities.CcIaxBuddies> queryable, string port)
            {
                return queryable.Where(q => q.Port == port);
            }

            #endregion

        }
    }

using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NesopsService.Configs;
using NesopsService.Data;
using NesopsService.Data.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using HashLib;
using System.Text.RegularExpressions;
using NesopsService.Utils;

namespace NesopsService.Services
{
    public class AuthorizeService
    {
        private Mya2billingContext _dbContext;
        public AuthorizeService(Mya2billingContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<AuthenticationTicket> GetAuthenticateTicketAsync(string username, string password)
        {
            var user = await _dbContext.Set<CcCard>().AsNoTracking().FirstOrDefaultAsync(p => p.Username == username);
            if (user == null)
            {
                user = await _dbContext.Set<CcCard>().AsNoTracking().FirstOrDefaultAsync(p => p.Useralias == username);
                if (user == null) return null;
            }
            if (user.Uipass != NesopsUtil.GenerateMD5FromString(user.Username + ":a2billing:" + password))
                return null;
            var identity = new ClaimsIdentity();
            identity.AddClaim(new Claim(ClaimTypes.Name, user.Username));
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
            identity.AddClaim(new Claim(ClaimTypes.Role, "Customer"));
            var principal = new ClaimsPrincipal(identity);
            var prop = new AuthenticationProperties()
            {
                IssuedUtc = DateTime.UtcNow,
                ExpiresUtc = DateTime.UtcNow.AddDays(1)
            };
            return new AuthenticationTicket(principal, prop, "application");
        }
        public IDictionary<string, object> GetTokenResponse(AuthenticationTicket ticket)
        {
            var res = new Dictionary<string, object>();
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(NesopsJWTConfiguration.SECRETKEY);
            //var issuer = NesopsJWTConfiguration.ISSUER;
            //var audience = NesopsJWTConfiguration.AUDIENCE;
            var identity = ticket.Principal.Identity as ClaimsIdentity;
            //identity.AddClaim(new Claim(JwtRegisteredClaimNames.Jti, identity.FindFirst(ClaimTypes.NameIdentifier).Value));
            //identity.AddClaim(new Claim(JwtRegisteredClaimNames.Sub, ticket.Principal.Identity.Name));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                //Issuer = issuer,
                //Audience = audience,
                Subject = new ClaimsIdentity(identity),
                IssuedAt = ticket.Properties.IssuedUtc?.UtcDateTime,
                Expires = ticket.Properties.ExpiresUtc?.UtcDateTime,
                NotBefore = ticket.Properties.IssuedUtc?.UtcDateTime,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateJwtSecurityToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            res["access_token"] = tokenString;
            if (ticket.Properties.ExpiresUtc != null)
                res["expire_utc"] = ticket.Properties.ExpiresUtc;
            if (ticket.Properties.IssuedUtc != null)
                res["issued_utc"] = ticket.Properties.IssuedUtc;
            return res;
        }
        public async Task<AuthenticationTicket> GetRootAuthenticateTicketAsync(string username, string password)
        {
            var user = await _dbContext.Set<CcUiAuthen>().AsNoTracking().FirstOrDefaultAsync(p => p.Login == username);
            if (user == null) return null;

            IHash hash = HashFactory.Crypto.CreateWhirlpool();
            HashResult r = hash.ComputeString(password, Encoding.ASCII);
            string passwordEncoded = Regex.Replace(r.ToString(), "-", string.Empty).ToLower();

            if (user.PwdEncoded != passwordEncoded)
                return null;
            var identity = new ClaimsIdentity();
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Userid.ToString()));
            identity.AddClaim(new Claim(ClaimTypes.Role, "Administrator"));
            var principal = new ClaimsPrincipal(identity);
            var prop = new AuthenticationProperties()
            {
                IssuedUtc = DateTime.UtcNow,
                ExpiresUtc = DateTime.UtcNow.AddDays(1)
            };
            return new AuthenticationTicket(principal, prop, "application");
        }
    }
}

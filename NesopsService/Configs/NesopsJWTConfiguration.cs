using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Configs
{
    public static class NesopsJWTConfiguration
    {
        public static string SECRETKEY = "NesopsPrivateKey";
        public static string ISSUER = "http://api.nesops.xyz";
        public static string AUDIENCE = "http://api.nesops.xyz";
        //public static string ExpireDays = "5";
    }
    public static class JWTBuilder
    {
        public static void BuildJWTService(IServiceCollection services)
        {
            //Authentication Schema
            const string scheme = JwtBearerDefaults.AuthenticationScheme;
            // Add authentication
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = scheme;
                    options.DefaultChallengeScheme = scheme;
                })
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(NesopsJWTConfiguration.SECRETKEY))
                    };
                });
        }
    }
}

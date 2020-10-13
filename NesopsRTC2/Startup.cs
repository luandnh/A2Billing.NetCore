using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using NesopsRTC2.Utils.Filters;
using NesopsService;
using NesopsService.Data;

namespace NesopsRTC2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Mya2billingContext>(options => options.UseMySql(Configuration.GetConnectionString("MyA2billingDB")));
            #region
            ServiceRootConfig.Entry(services, Configuration);
            #endregion
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("nesopsrtc", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Nesops RTC Swagger Docs",
                    Description = "Nesops RTC for Authorize Services",
                    Contact = new OpenApiContact
                    {
                        Name = "LuanDNH",
                        Email = "luandnh1998@gmail.com",
                        Url = new Uri("https://www.facebook.com/luandnh98")
                    },
                    TermsOfService = new Uri("http://nesops.xyz"),
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("http://nesops.xyz")
                    }
                });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            //services.AddCors(options =>
            //{
            //    options.AddPolicy(options.DefaultPolicyName,
            //    builder =>
            //    {
            //        builder.AllowAnyHeader();
            //        builder.AllowAnyMethod();
            //    });
            //});
            services.AddControllersWithViews(options =>
            {
                options.Filters.Add(typeof(ValidatorActionFilter));
            }).AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseRouting();
            app.UseCors(builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();
            #region Swagger Config
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/nesopsrtc/swagger.json", "Nesops RTC");
                //c.RoutePrefix = string.Empty;
            });
            #endregion
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Avam.ArticleStore.Web.Domain.Data.Repositories;
using Avam.ArticleStore.Web.Domain;
using Avam.ArticleStore.Web.Data;
using Avam.ArticleStore.Web.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Avam.ArticleStore.Web.Models.Converters;

namespace Avam.ArticleStore.Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                //.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddJsonOptions(x => {
                    x.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                });
            services.AddRouting();
            ConverterRegisterationHelper.Register(services);
            services.AddDbContext<ArticleContext>(options => options.UseSqlite("Filename=./articles.db"));
            services.AddScoped<DbContext, ArticleContext>();
            services.AddScoped<IRepository<Tag>, GenricRepository<Tag>>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddSingleton(provider => Configuration);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseMvc(ConfigureRoutes);
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            
            routeBuilder.MapRoute("controlpanel", "controlpanel/{*catchall}",
                new { controller = "Home", action = "ControlPanel" });
            routeBuilder.MapRoute("articles", "articles/{*catchall}",
                new { controller = "Home", action = "Index" });
            
            routeBuilder.MapRoute("Default",
                "{controller=Home}/{action=Index}/{id?}");
        }
    }
}

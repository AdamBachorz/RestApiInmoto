using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RestApiInmoto.API.Config;
using RestApiInmoto.DAL.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInmoto.API
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
            services.AddControllers()
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );


            var customConfig = Configuration.GetSection(typeof(CustomConfig).Name).Get<CustomConfig>();
            //if (customConfig.IsProduction)
            //{
            //    customConfig.ConnectionString =
            //            string.Format(customConfig.ConnectionString, "yexrewgv", "yEddLBhAqpuYlHD5LOCIq3gXuHs6taI0", "tai.db.elephantsql.com", "yexrewgv"); 
            //}


            services.AddDbContext<ArvenaDbContext>(
                //options => options.UseSqlServer(customConfig.ConnectionString)
                );

            services.AddSingleton<ICustomConfig>(x => customConfig);
            DependencyInjection.RegisterModules(services);

            var t = new ArvenaDbContext(customConfig).Sklep.Take(5).ToList();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

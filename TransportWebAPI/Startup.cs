using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using DBLayerPOC.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using TransportWebAPI.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using System.IO;

namespace TransportWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.ConfigureCors();
            services.ConfigureIISIntegration();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            services.AddMvc().AddJsonOptions(options => {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            }); ;

            services.AddEntityFrameworkSqlServer()
              .AddDbContext<AppDbContext>(options =>
              {
                  options.UseSqlServer(Configuration.GetConnectionString("ConnectionString"),
                                       sqlOptions => sqlOptions.MigrationsAssembly("WebApplication"));
              },
              ServiceLifetime.Scoped // Note that Scoped is the default choice
              // in AddDbContext. It is shown here only for
                // pedagogic purposes.
              );

            services.AddTransient<Seeder>();
 
            var builder = new ContainerBuilder();
            builder.RegisterModule(new RepositoryHandlerModule());
            builder.Populate(services);
            var container = builder.Build();
            // Create the IServiceProvider based on the container.
            return new AutofacServiceProvider(container);
        }


            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.Use(async (context, next) =>
                {
                    await next();
                    if (context.Response.StatusCode == 404 && !Path.HasExtension(context.Request.Path.Value))
                    {
                        context.Request.Path = "/index.html";
                        await next();
                    }
                });
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors("CorsPolicy");
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}

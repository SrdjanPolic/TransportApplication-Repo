using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TransportWebAPI.Extensions
{
    public static class ServiceExtensions
    {
        
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
           {

           });
        }

        public static void ConfigureExceptionHandler(this IApplicationBuilder app, EmailSendingClient emailSendingClient)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        emailSendingClient.SendLogEmail($"Something went wrong: {contextFeature.Error}");

                        await context.Response.WriteAsync($"Internal server error: {context.Response.StatusCode.ToString()}, {contextFeature.Error}");
                    }
                });
            });
        }
    }
}

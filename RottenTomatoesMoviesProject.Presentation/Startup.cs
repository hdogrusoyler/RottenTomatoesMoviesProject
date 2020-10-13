using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RottenTomatoesMoviesProject.ApiAccess.Abstract;
using RottenTomatoesMoviesProject.ApiAccess.Concrete;
using RottenTomatoesMoviesProject.BusinessLogic.Abstract;
using RottenTomatoesMoviesProject.BusinessLogic.Concrete;

namespace RottenTomatoesMoviesProject.Presentation
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
            services.AddHttpClient();

            //services.AddHttpClient<RottenTomatoesMoviesProject.Entity.Model.Movie>((sp, httpClient) =>
            //{
            //    // For sample purposes, assume TodoClient is used in the context of an incoming request.
            //    var httpRequest = sp.GetRequiredService<IHttpContextAccessor>().HttpContext.Request;

            //    httpClient.BaseAddress = new Uri(UriHelper.BuildAbsolute(httpRequest.Scheme, httpRequest.Host, httpRequest.PathBase));
            //    httpClient.Timeout = TimeSpan.FromSeconds(5);
            //});

            services.AddControllersWithViews();

            services.AddScoped<IProjectService, ProjectManager>();
            services.AddScoped<IProjectAAL, ProjectAAL>();
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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

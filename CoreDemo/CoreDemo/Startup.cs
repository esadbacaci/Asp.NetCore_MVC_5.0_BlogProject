using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;

namespace CoreDemo
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
            services.AddControllersWithViews();
			services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
            services.AddMvc();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = "UserScheme";
            })
 .AddCookie()
 .AddCookie("AdminScheme", options =>
 {
     options.LoginPath = "/Admin/Index"; // Admin rol�ne sahip kullan�c�lar� y�nlendirece�imiz login sayfas�
     options.AccessDeniedPath = "/Admin/Index";
	 options.ExpireTimeSpan = TimeSpan.FromHours(1);
 })
 .AddCookie("UserScheme", options =>
 {
     options.LoginPath = "/Login/Index"; // User rol�ne sahip kullan�c�lar� y�nlendirece�imiz login sayfas�
     options.AccessDeniedPath = "/Login/Index";
	 options.ExpireTimeSpan = TimeSpan.FromHours(1);
 });

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();

            //app.UseSession();//videoda g�remedim

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                   endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area:exists}/{controller=Widget}/{action=Index}/{id?}"
        );

                    endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Blog}/{action=Home}/{id?}");

            });
        }
    }
}

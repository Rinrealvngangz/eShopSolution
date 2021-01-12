using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Data.EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using eShopSolution.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using eShopSolution.Application.Catalog.Products;
using Microsoft.OpenApi.Models;
using eShopSolution.Application.Common;
using Microsoft.AspNetCore.Identity;
using eShopSolution.Data.Entities;
using eShopSolution.Application.System.Users;
using Microsoft.IdentityModel.Logging;

namespace eShopSolution.Backend.Api
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
            services.AddIdentity<AppUser,AppRole>()
                    .AddEntityFrameworkStores<EShopDbContext>()
                    .AddDefaultTokenProviders();
            //Declare DI
            services.AddTransient<IPublicProductService, PublicProductService>();
             services.AddTransient<IManageProductService,ManageProductService>();
             services.AddTransient<IstorageService,FileStorageService>();
             services.AddTransient<UserManager<AppUser>,UserManager<AppUser>>();
             services.AddTransient<SignInManager<AppUser>,SignInManager<AppUser>>();
            services.AddTransient<RoleManager<AppRole>,RoleManager<AppRole>>();
             services.AddTransient<IUserService,UserService>();
            

            services.AddDbContext<EShopDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString(SystemConstants.MainConnectionString)));
            services.AddControllersWithViews();
            
            //Swagger
            services.AddSwaggerGen(c=>{
                      c.SwaggerDoc("v1",new OpenApiInfo{Title = "eShop Solution", Version= "v1" });
            });
                

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                IdentityModelEventSource.ShowPII = true; 
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

           app.UseSwagger();

           app.UseSwaggerUI(c=>{
               c.SwaggerEndpoint("/swagger/v1/swagger.json","Swagger eShopSolution v1");
               
               });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

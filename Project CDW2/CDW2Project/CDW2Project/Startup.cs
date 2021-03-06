﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CDW2Project.AutoMapper;
using DatabaseModel.CustomIdentityUser;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModelDatabase;

namespace CDW2Project
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
            services.AddDbContext<ApplicationDbContext>(config =>
            {
                config.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddIdentity<UserAccount, IdentityRole>(config =>
            {
                config.Password.RequireDigit = true;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
                config.Password.RequiredUniqueChars = 1;
                config.Lockout.MaxFailedAccessAttempts = 5;


            }).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            services.ConfigureApplicationCookie(config =>
            {
                config.Cookie.Name = "UserIdentityCookie";
                config.LoginPath = "/Loginin/Index";
                config.AccessDeniedPath = "/Loginin/Index";
                config.ExpireTimeSpan = TimeSpan.FromDays(2);
            });
            services.AddAuthentication().AddGoogle(config =>
            {
                //config.ClientId = "991045662343-rudbuv8qtplqek39a1r5c4j6bme1lfuh.apps.googleusercontent.com";
                //config.ClientSecret = "O7NA66LKIhJbCrP0CGrCaLsJ";
                config.ClientId = "991045662343-rtminlirfs5c9thben6obm6qge8jld4q.apps.googleusercontent.com";
                config.ClientSecret = "ksszksfTyJ9tWqvee53YdQv6";
            });
            services.AddMvc(options => options.EnableEndpointRouting = false)
                .AddJsonOptions((opt) => {
                opt.JsonSerializerOptions.ReadCommentHandling = System.Text.Json.JsonCommentHandling.Skip; //skipp comment cho model
                opt.JsonSerializerOptions.PropertyNamingPolicy = null; // tránh Property Naming Policy tham chiếu
                });
            services.AddControllers().AddNewtonsoftJson(opt =>
            {
                opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
            services.AddSession(options =>
            {
                options.Cookie.Name = "sessionCookie";
                options.IdleTimeout = TimeSpan.FromDays(5);
                options.Cookie.IsEssential = true;
            });
            services.AddRazorPages();
            services.AddControllersWithViews();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Loginin}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "mvcAreaRoute",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

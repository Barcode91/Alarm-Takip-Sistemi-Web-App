using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.mehmet.core.DataAccess.NHibernate;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.Business.Manager;
using com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate;
using com.mehmet.proje.DataAccess.SomutSiniflar.NHibernate.ErisimSiniflari;
using com.mehmet.proje.DataAccess.SoyutSiniflar;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace com.mehmet.proje.MVCWebUI
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
            
            //services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddSingleton<IActionContextAccessor,ActionContextAccessor>();
            
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(config =>
                {
                    config.LoginPath = "/";
                });
            services.AddAuthorization(x => x.AddPolicy("UserClaimPositionPolicy", policy => policy.RequireClaim("gorevturu", "yönetici")));
            services.AddAuthorization(x => x.AddPolicy("UserClaimPositionPolicy2", policy => policy.RequireClaim("gorevturu", "operatör")));
            services.AddAuthorization(x => x.AddPolicy("UserClaimPositionPolicy3", policy => policy.RequireClaim("gorevturu", "müsteri")));
            services.AddScoped<ISinyallerService, SinyallerManager>(); // Servisler Tanıtır.
            services.AddScoped<ISinyallerDal, NhSinyallerDal>();
            services.AddScoped<NhibernateHelper, PostgreHelper>();// Kullanım mantığı <İnterface, Onu implement eden class>
            services.AddScoped<IMusteriService, MusteriManager>(); // Servisler Tanıtır.
            services.AddScoped<IMusteriDal, NhMusteriDal>();
            services.AddScoped<IAranacakService, AranacakManager>(); // Servisler Tanıtır.
            services.AddScoped<IAranacakDal, NhAranacakDal>();
            services.AddScoped<IPersonelService, PersonelManager>(); // Servisler Tanıtır.
            services.AddScoped<IPersonelDal, NhPersonelDal>();
            services.AddScoped<IIslenmisSinyallerService, IslenmisSinyallerManager>(); // Servisler Tanıtır.
            services.AddScoped<IIslenmisSinyaller, NhIslenmisSinyallerDal>();
            services.AddSession(); // oturum işlemini aktif et
            services.AddDistributedMemoryCache();// oturum bilgisi bellekte tut
            
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder => builder.WithOrigins("https://localhost:5001",
                        "http://localhost:5001/Operator/")
                        .AllowAnyHeader()
                        .AllowAnyMethod());

            });
            
            
            
            
            
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {  if (env.IsDevelopment())
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
            app.UseRouting();
            app.UseCors();
            app.UseSession();
            app.UseAuthentication();
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
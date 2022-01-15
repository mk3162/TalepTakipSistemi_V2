using Common.Services.Implementation;
using Common.Services.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // Uygulamada kullanýlacak servisler buraya eklenir.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();

            //Uygulamada DI yapýsý üzerinden eriþilen tüm IDBService nesne referanslarý bir DBService nesnesi olarak gelecek.
            services.AddSingleton<IDBService, DBService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // launchSettings.json dosyasýndaki bileþenlere eriþmek için yazýlan class’larýmýzý bu metot üzerinden DI yapýsýna enjekte edebiliyoruz.
        // Servis ayarlarý yapýlýr.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });

            //app.UseStaticFiles();   // Javascript,css,resim gibi dosyalarý kullanmak için
            
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api");
            });
            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuTodo.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MeuTodo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) //Método onde são configurados os serviços utilizados pela aplicação.
        {
            services.AddControllers(); //Adiciona serviços necessários para suportar controllers na aplicação.
            services.AddDbContext<AppDbContext>(); 
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();// Habilita o roteamento de requisições HTTP para os controllers e endpoints definidos na aplicação.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Site01.Database;

namespace Site01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //providers - bibliotecas de conexões com o banco - oracle, mysql, postgresql...
            services.AddDbContext<DatabaseContext>(options => {
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=site01;Integrated Security=True;");
            });

            //serviço de sessão --> controle login
            services.AddDistributedMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //neste método definimos o comportamento da aplicação


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //indicar que a aplicação irá utilizar sessão
            app.UseSession();

            app.UseStaticFiles();

            /*
             * definindo a rota padrão... URL que será acionada como padrão ao acessar a aplicação
             * wwww.site.com/cliente/listar
             * {domnínio}/{controller}/{Action}/{id?}
             */
            
            app.UseMvcWithDefaultRoute();

            /*app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/
        }
    }
}

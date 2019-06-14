using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace study_aspnet
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Livro 01", 10.00m));
            livros.Add(new Livro("002", "Livro 02", 11.00m));
            livros.Add(new Livro("003", "Livro 03", 12.00m));

            app.Run(async (context) =>
            {
                foreach (var livro in livros) {
                    await context.Response.WriteAsync($"{livro.Codigo,-10}{livro.Name,-40}{livro.Preco.ToString("C"),10}\r\n");
                }
            });
        }
    }
}

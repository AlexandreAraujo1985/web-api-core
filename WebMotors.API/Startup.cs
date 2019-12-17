using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using WebMotors.Data.Repository;
using WebMotors.Data.Repository.Interfaces;

namespace WebMotors.API
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(name: "v1", info: new Info
                {
                    Title = "Anuncio",
                    Version = "v1"
                });
            });

            services.AddDbContext<WebMotorsContext>(x => x.UseInMemoryDatabase("teste_webmotors"));
            services.AddScoped<IAnuncioRepository, AnuncioRepository>();
            services.AddAutoMapper();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", description: "Anuncio");
            });
        }
    }
}
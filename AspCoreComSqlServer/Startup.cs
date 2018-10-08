using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreComSqlServer.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace AspCoreComSqlServer
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
            services.AddMvc();

            // para usar o swagger basta instalar o pacote no nugget e usar as configurações.
            // Install-Package Swashbuckle.AspNetCore no console e no package instalar Swashbuckle.AspNetCore

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info { Title = "Minha Api", Version = "v1" });
            });

            string minhaCon = @"server=DESKTOP-NQP6NJ3\WCASTRO;DataBase=WEBAPIS;Trusted_Connection=true;";

            services.AddDbContext<ProductContext>(opt => opt.UseSqlServer(minhaCon));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyApi V1");
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}

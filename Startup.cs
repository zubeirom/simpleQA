using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SimpleQa.Services;
using SimpleQa.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace SimpleQa
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddMvcOptions(o => o.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter()));

            services.AddScoped<ISimpleQaRepository, SimpleQaRepository>();

            var connectionString = Configuration["connectionStrings:simpleQaConnectionString"];

            services.AddDbContext<SimpleQaContext>(o => o.UseSqlServer(connectionString));

            services.AddAutoMapper(typeof(Startup));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SimpleQaContext simpleQaContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();  // Only useful when having web server with ssl
                app.UseExceptionHandler("/error");
            }

            simpleQaContext.EnsureSeedDataForContext();
            
            app.UseStatusCodePages();
            app.UseHttpsRedirection(); // Only useful when having web server with ssl
            app.UseMvc();
        }
    }
}

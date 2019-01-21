using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using System;

namespace SuperDigital.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(Options =>
            {
                Options.AddPolicy(
                    "CorsPolicy",
                    builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });



            services.AddMvc();
            //services.AddMvcCore().AddVersionedApiExplorer(c =>
            //{
            //    c.GroupNameFormat = "'v'VVV";
            //    c.SubstituteApiVersionInUrl = true;
            //});

            //services.AddApiVersioning(setup => {
            //    setup.ReportApiVersions = true;
            //    setup.AssumeDefaultVersionWhenUnspecified = true;
            //    setup.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(0, 1);
            //});

            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                     new Info
                     {
                         Title = "Super Digital",
                         Version = "v1",
                         Description = "API REST criada com o ASP.NET Core",
                         Contact = new Contact
                         {
                             Name = "Leandro Flora",
                             Url = "https://github.com/leandroflora"
                         }
                     });
            });

            services.ConfigureSwaggerGen(options =>
            {
                //Register the file operation for upload
                //options.OperationFilter<FormFileOperationFilter>();

                options.DescribeAllEnumsAsStrings();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {

                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Super Digital");
            });

            app.UseCors("CorsPolicy");

            app.UseMvc();
        }
    }
}


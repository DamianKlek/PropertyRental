using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PropertyRental.Application;
using PropertyRental.Persistance;
using PropertyRental.Infrastructure;
using System;
using System.IO;
using Serilog;

namespace PropertyRental
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
			services.AddApplication();
			services.AddInfrastructure(Configuration);
			services.AddPersistance(Configuration);
			services.AddControllers();

			services.AddCors(options =>
								options.AddPolicy(name: "AllowAll",
										builder =>
										{
											builder.AllowAnyOrigin(); // Any movement from external APIs is allowed
																								//builder.WithOrigins("https://localhost:44330"); // Only specyfic app address is allowed
										}
						));

			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "PropertyRental",
					Version = "v1",
					Description = "Simple web application that allows to place rental offers and orders"
				});
				var filePath = Path.Combine(AppContext.BaseDirectory, "PropertyRental.xml");
				c.IncludeXmlComments(filePath);
			});

			services.AddHealthChecks();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PropertyRental v1"));
			}
			app.UseHealthChecks("/hc");
			app.UseHttpsRedirection();
			app.UseSerilogRequestLogging();
			app.UseRouting();

			app.UseCors(); // Cors should appear between app.UseRouting(); and app.UseAuthorization();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}

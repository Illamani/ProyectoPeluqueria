using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PeluqueriaApi.EntityFrameWork;
using PeluqueriaApi.EntityFrameWork.Repositorios;
using PeluqueriaApi.Interfaces;
using PeluqueriaApi.Servicios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PeluqueriaApi
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
			services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
			{
				builder.AllowAnyOrigin()
					   .AllowAnyMethod()
					   .AllowAnyHeader();
			}));

			IConfigurationRoot configuration = new ConfigurationBuilder()
					.SetBasePath(Directory.GetCurrentDirectory())
					.AddJsonFile("appsettings.json")
					.Build();

			string connectionString = configuration.GetConnectionString("DefaultConnection");

			services.AddDbContext<AppDbContext>(options =>
			{
				options.UseSqlServer(connectionString);
			});


			services.AddScoped<ITurnoService, TurnoService>();
			services.AddScoped<ITurnoRepositorio, TurnoRepositorio>();

			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "PeluqueriaApi", Version = "v1" });
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PeluqueriaApi v1"));
			}

			using (var scope = app.ApplicationServices.CreateScope())
			{
				var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
				dbContext.Database.EnsureCreated();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseCors("MyPolicy");

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}

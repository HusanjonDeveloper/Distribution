using Distribution.Brokers.Storages;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Distribution
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc(
                    name: "v1",
                    info: new OpenApiInfo { Title = "Distribution", Version = "v1" });
            });

            services.AddTransient<IStorageBroker, StorageBroker>(); 
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment enverimant)
        {
            if (enverimant.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(config =>
                config.SwaggerEndpoint(
                    url: "/swagger/v1/swagger.json",
                    name: "Distribution v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
                endpoints.MapControllers());

        }
    }
}

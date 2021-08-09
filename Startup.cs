using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Dirs21.Models;
using Dirs21.Services;
using Microsoft.Extensions.Options;

namespace Dirs21
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
            services.Configure<Dirs21DatabaseSettings>(
                           Configuration.GetSection(nameof(Dirs21DatabaseSettings)));

            services.AddSingleton<IDirs21DatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<Dirs21DatabaseSettings>>().Value);

            services.AddSingleton<Dirs21Service>();
            services.AddControllers().AddJsonOptions(Options => Options.JsonSerializerOptions.PropertyNamingPolicy=null);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(builder => builder.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader()
                                );

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseAuthorization();            
            app.UseFileServer();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

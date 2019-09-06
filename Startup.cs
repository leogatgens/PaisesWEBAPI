using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaisesWEBAPI.Context;
using PaisesWEBAPI.Converters;
using PaisesWEBAPI.Services;

namespace PaisesWEBAPI
{
    public class Startup
    {
        public const string AppS3BucketKey = "AppS3Bucket";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration Configuration { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var connectionString = Configuration["connectionStrings:libraryDBConnectionString"];
            var connectionStringReports = Configuration["connectionStrings:libraryDBConnectionStringReports"];
            services.AddDbContext<TripsContext>(o => o.UseSqlServer(connectionString));
            services.AddDbContext<ReportContext>(o => o.UseSqlServer(connectionStringReports));
            services.AddScoped<ITripsRepository, TripsRepository>();
            services.AddScoped<IPaisesRepository, TripsRepository>();
            services.AddScoped<IWishListRepository, TripsRepository>();
            services.AddScoped<ITravelerRepository, TravelerRepository>();
            services.AddScoped<IReportesRepository, ReportesRepository>();
            services.AddScoped<IConverter, Converter>();


            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = "https://leogatgens.auth0.com/";
                options.Audience = "https://leogatgensAPI";
            });
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("read:messages", policy => policy.Requirements.Add(new HasScopeRequirement("read:messages", domain)));
            //});


            // Add S3 to the ASP.NET Core dependency injection framework.
            services.AddAWSService<Amazon.S3.IAmazonS3>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.Use(async (ctx, next) =>
            {
                await next();
                if (ctx.Response.StatusCode == 204)
                {
                    ctx.Response.ContentLength = 0;
                }
            });

            app.UseCors(builder =>
            builder.WithOrigins("http://localhost:3000", "http://diaroviajero.com", "https://diaroviajero.com", "http://172.16.73.123:3000")
           .AllowAnyHeader()
           .AllowAnyMethod()
       );

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }


            app.UseStaticFiles();

            // 2. Enable authentication middleware
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "default",
                  template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AsthmaAlertApi.Data;
using AsthmaAlertApi.Models;
using AsthmaAlertApi.Services;
using AsthmaAlertApi.Repositories;
using JsonApiDotNetCore.Extensions;
using JsonApiDotNetCore.Routing;
using JsonApiDotNetCore.Data;
using Microsoft.AspNetCore.Identity;
using AspNet.Security.OpenIdConnect.Primitives;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace AsthmaAlertApi
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
            // services.Configure<CookiePolicyOptions>(options =>
            // {
            //     // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //     options.CheckConsentNeeded = context => true;
            //     options.MinimumSameSitePolicy = SameSiteMode.None;
            // });

            services.AddCors();

            services.AddJsonApi<AppDbContext>(opt => opt.Namespace = "api/v1");

            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<AppDbContext>(opt => {
                opt.UseNpgsql(GetConnectionString());
                opt.UseOpenIddict();
            });

              // Register the Identity services.
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

             // Register the OpenIddict services.
            services.AddOpenIddict()
                .AddCore(options =>
                {
                    // Configure OpenIddict to use the Entity Framework Core stores and entities.
                    options.UseEntityFrameworkCore()
                        .UseDbContext<AppDbContext>();
                })

                .AddServer(options =>
                {
                    // Register the ASP.NET Core MVC binder used by OpenIddict.
                    // Note: if you don't call this method, you won't be able to
                    // bind OpenIdConnectRequest or OpenIdConnectResponse parameters.
                    options.UseMvc();

                    // Enable the token endpoint (required to use the password flow).
                    options.EnableTokenEndpoint("/connect/token");

                    // Allow client applications to use the grant_type=password flow.
                    options.AllowPasswordFlow();
                    options.AllowRefreshTokenFlow();

                    // During development, you can disable the HTTPS requirement.
                    options.DisableHttpsRequirement();

                    // Accept token requests that don't specify a client_id.
                    options.AcceptAnonymousClients();
                })
                .AddValidation();

            services.Configure<IdentityOptions>(options =>
            {
                options.ClaimsIdentity.UserNameClaimType = OpenIdConnectConstants.Claims.Name;
                options.ClaimsIdentity.UserIdClaimType = OpenIdConnectConstants.Claims.Subject;
            });

           // services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IEntityRepository<TrackingItem>, TrackingItemRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory,
            AppDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));

            var logger = loggerFactory.CreateLogger<Startup>();
            logger.LogInformation($"Starting application in {env.EnvironmentName} environment");

            if (env.IsDevelopment())
                app.UseCors(builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
                });

            app.UseAuthentication();

            app.UseJsonApi();

            SeedDatabase(context, userManager).Wait();
        }

        private async Task SeedDatabase(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            if(!await context.Users.AnyAsync())
            {
                var user = new ApplicationUser {
                    UserName = "guest",
                    Email = "camhelkuik@gmail.com"
                };

                var result = await userManager.CreateAsync(user, "Guest1!");
                if(!result.Succeeded) throw new Exception("Could not create default user");

                context.TrackingItems.Add(new TrackingItem {
                    Owner = user,
                    Date = "09/09/2019",
                    HadAttack = 0,
                    TrackingTitle = "Linus"
                });

                context.TrackingItems.Add(new TrackingItem {
                    Date = "09/08/2019",
                    HadAttack = 1,
                    TrackingTitle = "Not Owned"
                });

                context.SaveChanges();
            }
        }

        private string GetConnectionString()
        {
            return Configuration["ConnectionString"];
        }
    }
}

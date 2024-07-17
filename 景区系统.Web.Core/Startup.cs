using Core.Auth;
using Core.Auth.Handler;
using Core.Cache;
using Furion;
using Furion.VirtualFileServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StackExchange.Redis;
using Core.MiddelWares;
using System.Text.Json;

namespace 景区系统.Web.Core;

public class Startup : AppStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddConsoleFormatter();
        services.AddJwt<JwtHandler>();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped<IHttpContextUser, JwtUserContext>();

        services.AddSingleton<ConnectionMultiplexer>(sp =>
        {
            //获取连接字符串
            string redisConfiguration = App.Configuration["RedisConfig:ConnectionString"];
            var configuration = ConfigurationOptions.Parse(redisConfiguration, true);
            configuration.ResolveDns = true;
            configuration.ChannelPrefix = App.Configuration["ServerConfig:CachePrefix"];
            configuration.DefaultDatabase = 1;
            return ConnectionMultiplexer.Connect(configuration);
        });
        services.Add(ServiceDescriptor.Singleton<ICacheOperation, RedisOperationRepository>());
        services.AddMyRateLimiter("default_rate_policy");
        services.AddMyRateLimiter("default_rate_policy1",5,60);
        services.AddRemoteRequest();

        services.AddCorsAccessor();

        services.AddControllersWithViews()
                        .AddInjectWithUnifyResult().AddJsonOptions(options =>
                        {
                            options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                            options.JsonSerializerOptions.PropertyNamingPolicy = null;
                            options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
                        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseCorsAccessor();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseInject();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}

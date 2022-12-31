using Application.Common.Interfaces;
using Hangfire;
using HangfireBasicAuthenticationFilter;
using Scheduler.Services;
using Infrastructure;
using System.Security.Authentication;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Infrastructure.Cache;
using DataService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel((context, serverOptions) =>
{
    serverOptions.Configure(context.Configuration.GetSection("Kestrel"))
        .Endpoint("Https", listenOptions =>
        {
            listenOptions.HttpsOptions.SslProtocols = SslProtocols.Tls12;
            listenOptions.ListenOptions.UseConnectionLogging();
            listenOptions.ListenOptions.Protocols = HttpProtocols.Http1AndHttp2;
        });
}).UseKestrel();

//Configure Hangfire
var connectionString = builder.Configuration.GetConnectionString("HangfireConnection");

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddTransient<IMarketData, MarketData>();
builder.Services.AddTransient<IDataService, InstrumentDataService>();
//builder.Services.AddTransient<ICachedMarketService, CachedMarketService>();
builder.Services.AddTransient<ICacheProvider, CacheProvider>();
builder.Services.AddSingleton<IBackgroundJobs, HangfireService>();
builder.Services.AddInfrastructure();
builder.Services.AddHttpClient();
builder.Services.AddLogging();
builder.Services.AddMemoryCache();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddHangfire(configuration => configuration
    .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
    .UseSimpleAssemblyNameTypeSerializer()
    .UseRecommendedSerializerSettings()
    .UseSqlServerStorage(connectionString, new Hangfire.SqlServer.SqlServerStorageOptions
    {
        CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
        SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
        QueuePollInterval = TimeSpan.Zero,
        UseRecommendedIsolationLevel = true,
        DisableGlobalLocks = true
    }));

// Add the processing server as IhostedService
builder.Services.AddHangfireServer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.UseHangfireDashboard("/hangfire", new DashboardOptions
{
    DashboardTitle = "MagnetScreener",
    Authorization = new[]
    {
        new HangfireCustomBasicAuthenticationFilter
        {
            User = builder.Configuration.GetSection("HangfireSettings:UserName").Value,
            Pass = builder.Configuration.GetSection("HangfireSettings:Password").Value
        }
    }
});

app.UseEndpoints(endpoint =>
{
    endpoint.MapControllers();
    endpoint.MapHangfireDashboard();
});


//builder.Services
var hangfireService = app.Services.GetService<IBackgroundJobs>();
RecurringJob.AddOrUpdate("Execute", () => hangfireService.Execute(), hangfireService.CronMagnetStrategy);//Every 15 minutes, between 09:00 AM and 12:59 PM


app.Run();

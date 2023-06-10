using ApiFinder.Infrastructure.DependencyInjection;
using ApiFinder.Infrastructure.ExternalServices.Abstract;
using ApiFinder.Infrastructure.ExternalServices.Concrete;
using ApiFinder.Infrastructure.Policies.ExternalServices;
using ApiFinder.Scheduler;
using Hangfire;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()    
    .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure();
builder.Services.AddHttpClient<IExternalServiceRequestHandler, ExternalServiceRequestHandler>()
     .AddPolicyHandler(ExternalServiceRequestHandlerPolicy.GetRetryPolicy())
     .AddPolicyHandler(ExternalServiceRequestHandlerPolicy.GetCircuitBreakerPolicy());
builder.Services.AddScheduler(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseHangfireDashboard("/dashboard");

app.UseAuthorization();

app.MapControllers();
 
app.Run();

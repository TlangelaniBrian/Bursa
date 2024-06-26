using bursaDAL;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<BursaContext>(
        options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("bursaConnection"),
            sqlOptions => sqlOptions.EnableRetryOnFailure().CommandTimeout(60))
        );

builder.Logging.ClearProviders();
builder.Host.UseSerilog((context, loggerConfig) => loggerConfig.ReadFrom.Configuration(context.Configuration));
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    });

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v0.0.1", new() { Title = "bursa", Version = "0.0.1" });
});

builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();
app.UseSerilogRequestLogging();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

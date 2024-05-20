using bursaAPI.Repository;
using bursaDAL;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<BursaContext>(
        options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("bursaConnection"),
            sqlOptions => sqlOptions.EnableRetryOnFailure().CommandTimeout(60))
        );

builder.Logging.ClearProviders();
builder.Host.UseSerilog((context, loggerConfig) => loggerConfig.ReadFrom.Configuration(context.Configuration));
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v0.0.1", new() { Title = "bursa", Version = "0.0.1" }); 
});
builder.Services.AddScoped<IBursaService, BursaService>();
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

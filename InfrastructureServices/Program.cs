using InfrastructureServices.Data;
using InfrastructureServices.Repositories;
using InfrastructureServices.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RequestSystemDBContext>(options => options.UseOracle(builder.Configuration.GetConnectionString("DataBase")));
builder.Services.AddScoped<IRequestForPrinterInstallation, RequestForPrinterInstallationRepository>();

builder.Services.AddCors(options => options.AddPolicy(name: "RequestForPrinterInstallationOrigins", policy =>
{
    policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("RequestForPrinterInstallationOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using Assigment;
using Assigment.Models;
using Assigment.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

//config.Filters.Add(new BasicAuthenticationAttribute());           

builder.Services.Configure<SureMDMDatabaseSettings>(
    builder.Configuration.GetSection(nameof(SureMDMDatabaseSettings)));

builder.Services.AddSingleton<ISureMDMDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<SureMDMDatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("SureMDMDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<ICustomerService, CustomerService>();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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

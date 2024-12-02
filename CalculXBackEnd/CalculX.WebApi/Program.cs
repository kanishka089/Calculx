using CalculX.WebApi;
using CalculXBase.Handlers;
using Microsoft.EntityFrameworkCore;
using AuthService;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
var config = new Configuration();
configuration.Bind("Configuration", config);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<DbContext, ApplicationDbContext>(options =>
    options.UseSqlServer(config.ConnectionString));

builder.Services.AddAuthServices();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<EncryptionHandler>();

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

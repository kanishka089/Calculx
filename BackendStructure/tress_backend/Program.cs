using Microsoft.EntityFrameworkCore;
using tress_backend;
using ElixirBase.Handlers;
using UserService;

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

builder.Services.AddUserServices();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<EncryptionHandler>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

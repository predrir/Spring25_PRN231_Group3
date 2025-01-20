using MedicalWarehouse_BusinessObject.Contract;
using MedicalWarehouse_BusinessObject.Entity;
using MedicalWarehouse_Services;
using MedicalWarehouse_Services.Interface;
using MedicalWarehouse_Services.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAuthorization();
builder.Services.AddAuthentication()/*.AddCookie(IdentityConstants.ApplicationScheme)
    .AddBearerToken(IdentityConstants.BearerScheme)*/;

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddApiEndpoints();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("local")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAuthService, AuthServices>();
builder.Services.AddScoped<TokenProvider>();
var app = builder.Build();

app.MapIdentityApi<User>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

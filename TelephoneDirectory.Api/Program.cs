using System.Text;
using TelephoneDirectory.Api;
using TelephoneDirectory.Business;
using TelephoneDirectory.DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using TelephoneDirectory.DataAccess.TelephoneDirectoryDbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.DataAccessRegistration(builder.Configuration); // Pass the required 'configuration' parameter
builder.Services.AddControllers();
builder.Services.BusinessRegistration();
builder.Services.AddHttpContextAccessor();
builder.Services.Configure<ConfigurationModel>(x => builder.Configuration.GetSection("AppSettings").Bind(x));

builder.Services.AddDbContext<TelephoneDirectoryDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("TelephoneDirectory.DataAccess")));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["AppSettings:Issuer"],
            ValidAudience = builder.Configuration["AppSettings:Audience"],
            IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(builder.Configuration["AppSettings:Token"]))
        };

    });
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

namespace TelephoneDirectory.Api
{
    class SymmetricSecurityKey
    {
        private object value;

        public SymmetricSecurityKey(object value)
        {
            this.value = value;
        }
    }
}


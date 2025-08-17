using System.Text;
using TelephoneDirectory.Api;
using TelephoneDirectory.Business;
using TelephoneDirectory.DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using TelephoneDirectory.DataAccess.TelephoneDirectoryDbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Servisleri ekle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.DataAccessRegistration(builder.Configuration);
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
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["AppSettings:Token"]))
        };
    });


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularDev", policy =>
    {
        policy.WithOrigins("http://localhost:4200") // Angular portu
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


var app = builder.Build();

app.UseCors("AllowAngularDev");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using CapaDatos;
using CapaDomain;



var builder = WebApplication.CreateBuilder(args);

// Configuraci�n de JWT en ConfigureServices
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

// Agrega los servicios de autorizaci�n
builder.Services.AddAuthorization();

builder.Services.AddSingleton(provider =>
    ConexionSingleton.GetInstance(provider.GetRequiredService<IConfiguration>()));

// Registrar el repositorio y la capa de dominio
builder.Services.AddScoped<UsserRepository>();
builder.Services.AddScoped<UsserDomain>();

builder.Services.AddControllers();

// Configuraci�n de Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API con JWT y Swagger",
        Version = "v1",
        Description = "API que utiliza JWT para autenticaci�n y Swagger para la documentaci�n"
    });

    // Configura Swagger para usar autenticaci�n JWT
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Ingrese 'Bearer' seguido de un espacio y su token JWT."
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

var app = builder.Build();

// En Configure, activa Swagger y Swagger UI solo en el entorno de desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API con JWT y Swagger v1");
        c.RoutePrefix = string.Empty; // Para que Swagger est� en la ruta ra�z
    });
}

// En Configure, activa la autenticaci�n y autorizaci�n
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();

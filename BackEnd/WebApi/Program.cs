using CapaDatos;
using CapaDomain;

var builder = WebApplication.CreateBuilder(args);

// Cargar la configuración desde appsettings.json
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// Registrar el patrón Singleton para la conexión a la base de datos
builder.Services.AddSingleton(provider =>
    ConexionSingleton.GetInstance(provider.GetRequiredService<IConfiguration>()));

// Registrar el repositorio y la capa de dominio
builder.Services.AddScoped<AlumnoRepository>();
builder.Services.AddScoped<AlumnoDomain>();

builder.Services.AddScoped<PrestamoRepository>();
builder.Services.AddScoped<PrestamoDomain>();

builder.Services.AddScoped<SancionRepository>();
builder.Services.AddScoped<SancionDomain>();

builder.Services.AddScoped<ReservaRepository>();
builder.Services.AddScoped<ReservaDomain>();

builder.Services.AddScoped<UsuarioRepository>();
builder.Services.AddScoped<UsuarioDomain>();

builder.Services.AddScoped<ComentarioRepository>();
builder.Services.AddScoped<ComentarioDomain>();

builder.Services.AddScoped<GeneroRepository>();
builder.Services.AddScoped<GeneroDomain>();

builder.Services.AddScoped<AutorRepository>();
builder.Services.AddScoped<AutorDomain>();


builder.Services.AddScoped<AutorRepository>();
builder.Services.AddScoped<AutorDomain>();

builder.Services.AddScoped<LibroRepository>();
builder.Services.AddScoped<LibroDomain>();

// Registrar los controladores
builder.Services.AddControllers();

// Configurar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
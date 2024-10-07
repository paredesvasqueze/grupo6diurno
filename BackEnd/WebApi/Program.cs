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

<<<<<<< HEAD
<<<<<<< HEAD
builder.Services.AddScoped<GeneroRepository>();
builder.Services.AddScoped<GeneroDomain>();
=======
builder.Services.AddScoped<AutorRepository>();
builder.Services.AddScoped<AutorDomain>();
>>>>>>> 0f1530fd79dabc530dff462321dcf9db4fa3fced
=======
builder.Services.AddScoped<LibroRepository>();
builder.Services.AddScoped<LibroDomain>();

>>>>>>> 4a5eba46f8df2fe1c0632a54ef3bd850c0cc8ec6

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
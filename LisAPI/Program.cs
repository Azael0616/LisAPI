using LisAPI.DAL;
using LisAPI.DAL.Interfaces;
using LisAPI.DAL.Utils;
using Microsoft.AspNetCore.Mvc.Routing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Obtener la cadena de conexión desde la configuración
string? cadena_de_conexion = builder.Configuration.GetConnectionString("DefaultConnection");
//Version
string version = builder.Configuration.GetSection("ApiInfo:Version").Value ?? "v0";
//CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularDev", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});
// Registrar la DAL en el DI
builder.Services.AddSingleton<ISqlAuxiliar>(new SqlAuxiliar(cadena_de_conexion));

//Registrar DAL
builder.Services.AddScoped<IViajeDAL, ViajeDAL>();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => Results.Json(new { status = "API CORRIENDO", version }));

app.UseCors("AllowAngularDev");

app.Run();

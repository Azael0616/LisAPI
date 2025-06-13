using LisAPI.DAL;
using LisAPI.DAL.Interfaces;
using LisAPI.DAL.Utils;
using Microsoft.AspNetCore.Mvc.Routing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Obtener la cadena de conexión desde la configuración
string? cadena_de_conexion = builder.Configuration.GetConnectionString("DefaultConnection");

// Registrar la DAL en el DI
builder.Services.AddSingleton<ISqlAuxiliar>(new SqlAuxiliar(cadena_de_conexion));

// Registrar la BLL, pasando la DAL (inyección automática)
builder.Services.AddScoped<IOperadorDAL,OperadorDAL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => Results.Json(new { status = "API CORRIENDO", version = "v1" }));

app.Run();

using API_Application_NLayer.Services.Parking;
using API_Infraestructure_Nlayers.DataBase.Context;
using API_Infraestructure_Nlayers.Repository.Parking;
using API_Infraestructure_Nlayers.Repository.Vehicle;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Asegúrate de registrar IVehicleRepository
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();

// También registra IParkingRepository
builder.Services.AddScoped<IParkingRepository, ParkingRepository>();

// Luego registra el servicio ParkingService
builder.Services.AddScoped<IParkingService, ParkingService>();

builder.Services.AddDbContext<ParkingContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Container.ConfiguracionDependencias(builder.Services, builder.Configuration);

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

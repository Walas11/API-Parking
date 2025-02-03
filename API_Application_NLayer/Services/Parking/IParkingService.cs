using API_Application_NLayer.Models.Parking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Application_NLayer.Services.Parking
{
    public interface IParkingService
    {
        void RegisterVehicle(VehicleDto Vehicle);
        void RegisterParkingRate(string licensePlate);
        List<ParkingDto> ListVehicles(DateOnly fechaIngreso, DateOnly fechaSalida, TimeOnly? horaIngreso = null, TimeOnly? horaSalida = null);
    }
}
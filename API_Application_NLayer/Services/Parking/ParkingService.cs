using API_Application_NLayer.Models.Parking;
using API_Domain_NLayer.Entitys.Parking;
using API_Infraestructure_Nlayers.Repository.Parking;
using API_Infraestructure_Nlayers.Repository.Vehicle;

namespace API_Application_NLayer.Services.Parking
{
    public class ParkingService : IParkingService
    {
        private readonly IParkingRepository _parkingRepository;
        private readonly IVehicleRepository _vehicleRepository;
        public ParkingService(IParkingRepository parkingRepository, IVehicleRepository vehicleRepository)
        {
            _parkingRepository = parkingRepository;
            _vehicleRepository = vehicleRepository;
        }

        /// <summary>
        /// Registrar vehiculo
        /// </summary>
        /// <param name="vehicle"></param>
        public async void RegisterVehicle(VehicleDto Vehicle)
        {
            try
            {
                VehicleEntity vehicleEntity = new VehicleEntity
                {
                    Placa = Vehicle.Placa,
                    TipoVehiculo = (int)Vehicle.TipoVehiculo
                };

                VehicleEntity vehivle = await _vehicleRepository.AddVehicle(vehicleEntity);
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Registrar cobro del vehiculo
        /// </summary>
        /// <param name="vehicle"></param>
        public void RegisterParkingRate(string licensePlate)
        {

        }

        /// <summary>
        /// Listado de vehiculos por rango de tiempo
        /// </summary>
        /// <param name="fechaIngreso"></param>
        /// <param name="fechaSalida"></param>
        /// <param name="horaIngreso"></param>
        /// <param name="horaSalida"></param>
        public List<ParkingDto> ListVehicles(DateOnly fechaIngreso, DateOnly fechaSalida, TimeOnly? horaIngreso = null, TimeOnly? horaSalida = null)
        {
            return null;
        }

    }
}

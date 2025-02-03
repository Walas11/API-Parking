using API_Domain_NLayer.Entitys.Parking;
using API_Infraestructure_Nlayers.DataBase.Context;

namespace API_Infraestructure_Nlayers.Repository.Vehicle
{
    public class VehicleRepository(ParkingContext context) : IVehicleRepository
    {
        private readonly ParkingContext _context = context;

        public async Task<VehicleEntity> AddVehicle(VehicleEntity VehicleEntity)
        {
            await _context.Vehicle.AddAsync(VehicleEntity);
            _context.SaveChanges();
            return VehicleEntity;
        }

        public List<VehicleEntity> GetVehicle()
        {
            return [.. _context.Vehicle];
        }

        public VehicleEntity GetVehicleByLicense(string placa)
        {
            return _context.Vehicle.FirstOrDefault(v => v.Placa == placa);
        }

        public VehicleEntity Update(VehicleEntity VehicleEntity)
        {
            _context.Vehicle.Update(VehicleEntity);
            _context.SaveChanges();
            return VehicleEntity;
        }
    }
}

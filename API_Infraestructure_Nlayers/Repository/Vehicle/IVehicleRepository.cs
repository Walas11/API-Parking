using API_Domain_NLayer.Entitys.Parking;

namespace API_Infraestructure_Nlayers.Repository.Vehicle
{
    public interface IVehicleRepository
    {
        Task<VehicleEntity> AddVehicle(VehicleEntity clienteEntity);
        List<VehicleEntity> GetVehicle();
        VehicleEntity GetVehicleByLicense(string placa);
        VehicleEntity Update(VehicleEntity clienteEntity);
    }
}

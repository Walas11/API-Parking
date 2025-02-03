using API_Application_NLayer.Enums.Parking;

namespace API_Application_NLayer.Models.Parking
{
    public class VehicleDto
    {
        public required string Placa { get; set; }
        public required VehicleType TipoVehiculo { get; set; }
    }
}

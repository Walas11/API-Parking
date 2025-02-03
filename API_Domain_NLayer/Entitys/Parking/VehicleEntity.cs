using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Domain_NLayer.Entitys.Parking
{
    [Table("Vehicle")]
    public class VehicleEntity
    {
        [Key]
        public required string Placa { get; set; }
        public required int TipoVehiculo { get; set; }
    }
}

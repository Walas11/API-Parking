using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Domain_NLayer.Entitys.Parking
{
    [Table("ParkingTransactions")]
    public class ParkingTransactionsEntity
    {
        [Key]
        public required VehicleEntity Vehicle { get; set; }
        public required DateOnly FechaIngreso { get; set; }
        public required TimeOnly HoraIngreso { get; set; }
        public DateOnly? FechaSalida { get; set; } = null;
        public TimeOnly? HoraSalida { get; set; } = null;
        public TimeOnly? TiempoEstacionado { get; set; } = null;
        public decimal ValorPagar { get; set; } = 0;
        public int NumFacturaDescuento { get; set; } = 0;
    }
}

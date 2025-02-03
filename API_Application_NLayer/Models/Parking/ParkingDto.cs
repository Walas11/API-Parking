namespace API_Application_NLayer.Models.Parking
{
    public class ParkingDto
    {
        public required VehicleDto Vehicle { get; set; }
        public required DateOnly FechaIngreso { get; set; }
        public required TimeOnly HoraIngreso { get; set; }
        public DateOnly? FechaSalida { get; set; } = null;
        public TimeOnly? HoraSalida { get; set; } = null;
        public TimeOnly? TiempoEstacionado { get; set; } = null;
        public decimal ValorPagar { get; set; } = 0;
        public int NumFacturaDescuento { get; set; } = 0;
    }
}
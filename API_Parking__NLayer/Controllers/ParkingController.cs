using API_Application_NLayer.Models.Parking;
using API_Application_NLayer.Services.Parking;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Parking__NLayer.Controllers
{
    [Route("api/Parking")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingService _parkingService;
        public ParkingController(IParkingService parkingService)
        {
            _parkingService = parkingService;
        }

        /// <summary>
        /// Obtener listado de vehiculos que se han estacionado en el parqueadero en rango de tiempo
        /// Tipo vehiculo, placa, tiempo de parqueadero y valor pagado
        /// </summary>
        /// <returns></returns>
        [HttpGet("ListVehicle/{fechaIngreso}/{fechaSalida}")]
        public List<ParkingDto> GetListVehicle(DateOnly fechaIngreso,  DateOnly fechaSalida, [FromQuery] TimeOnly? horaIngreso = null, [FromQuery] TimeOnly? horaSalida = null)
        {
            return _parkingService.ListVehicles(fechaIngreso, fechaSalida, horaIngreso, horaSalida);
        }

        /// <summary>
        /// Obtener informacion por placa del vehiculo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //[HttpGet("VehicleByLicensePlate/{licensePlate}")]
        //public VehicleDto GetVehicleByLicensePlate(string licensePlate)
        //{
        //    return _parkingService.;
        //}

        /// <summary>
        /// Registrar un vehiculo
        /// </summary>
        /// <param name="value"></param>
        [HttpPost("RegisterVehicle")]
        public void PostRegisterVehicle([FromBody] VehicleDto vehicle)
        {
            _parkingService.RegisterVehicle(vehicle);
        }

        /// <summary>
        /// Referencia de Cobro de estadia en el parqueadero
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("BillingVehicle/{licensePlate}")]
        public void PutBillingVehicle([FromBody] string licensePlate)
        {
            _parkingService.RegisterParkingRate(licensePlate);
        }
    }
}

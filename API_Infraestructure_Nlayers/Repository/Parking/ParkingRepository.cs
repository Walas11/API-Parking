using API_Domain_NLayer.Entitys.Parking;
using API_Infraestructure_Nlayers.DataBase.Context;
using System.Linq;

namespace API_Infraestructure_Nlayers.Repository.Parking
{
    public class ParkingRepository(ParkingContext context) : IParkingRepository
    {
        private readonly ParkingContext _context = context;

        public ParkingTransactionsEntity Add(ParkingTransactionsEntity parkingTransactionsEntity)
        {
            _context.Parking.Add(parkingTransactionsEntity);
            _context.SaveChanges();
            return parkingTransactionsEntity;
        }

        public List<ParkingTransactionsEntity> GetParking()
        {
            return [.. _context.Parking];
        }

        public ParkingTransactionsEntity Update(ParkingTransactionsEntity parkingTransactionsEntity)
        {
            _context.Parking.Update(parkingTransactionsEntity);
            _context.SaveChanges();
            return parkingTransactionsEntity;
        }
    }
}

using API_Domain_NLayer.Entitys.Parking;

namespace API_Infraestructure_Nlayers.Repository.Parking
{
    public interface IParkingRepository
    {
        ParkingTransactionsEntity Add(ParkingTransactionsEntity clienteEntity);
        List<ParkingTransactionsEntity> GetParking();
        ParkingTransactionsEntity Update(ParkingTransactionsEntity clienteEntity);
    }
}

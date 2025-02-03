using API_Domain_NLayer.Entitys.Parking;
using Microsoft.EntityFrameworkCore;

namespace API_Infraestructure_Nlayers.DataBase.Context
{
    public class ParkingContext : DbContext
    {
        public ParkingContext(DbContextOptions<ParkingContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        #region DBSets
        public virtual DbSet<ParkingTransactionsEntity> Parking { get; set; }
        public virtual DbSet<VehicleEntity> Vehicle { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParkingTransactionsEntity>(entity =>
            {
                entity.ToTable("ParkingTransactions");

                entity.Property(e => e.Vehicle.Placa)
                    .HasColumnName("NumeroPagosFuturos")
                    .IsRequired();
                entity.Property(e => e.Vehicle.TipoVehiculo)
                    .HasColumnName("NumeroPagosEnPedido")
                    .IsRequired();
                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("NumeroPagosRealizados")
                    .IsRequired();
                entity.Property(e => e.HoraIngreso)
                    .HasColumnName("NumPedido")
                    .IsRequired();
                entity.Property(e => e.FechaSalida)
                    .HasColumnName("EstadoPago")
                    .IsRequired();
                entity.Property(e => e.HoraSalida)
                    .HasColumnName("PrecioPedido")
                    .IsRequired();
                entity.Property(e => e.ValorPagar)
                    .HasColumnName("PrecioPedidoEuro")
                    .IsRequired();
                entity.Property(e => e.TiempoEstacionado)
                    .HasColumnName("ImportePagado")
                    .IsRequired();
                entity.Property(e => e.NumFacturaDescuento);
            });

            modelBuilder.Entity<VehicleEntity>(entity =>
            {
                entity.ToTable("Vehicle");

                entity.Property(e => e.Placa)
                    .HasColumnName("NumeroPagosFuturos");
                entity.Property(e => e.TipoVehiculo)
                    .HasColumnName("NumeroPagosEnPedido");
            });
        }
    }
}

using CleanArchitecture2024.Domain.Abstractions;

namespace CleanArchitecture2024.Domain.Vehiculos
{
    public sealed class Vehiculo : Entity
    {
        public Vehiculo(Guid id) : base(id)
        {
        }
        public Modelo? Modelo { get; private set; }
        public Vin? Vin { get; private set; }
        public Direccion Direccion { get; private set; }
        public decimal? Precio { get; private set; }

        public string? TipoMoneda { get; private set; }
        public int Mantenimiento { get; private set; }
        public string? ManteniminetoTipoMoneda { get; private set; }
        public DateTime? FechaUltimoAlquiler { get; private set; }
        public List<Accesorio> Accesorios { get; private set; } = new List<Accesorio>();
    }
}

using Microsoft.EntityFrameworkCore;
using GastosCore.Models; 

namespace GastosCore.Data
{
    public class GastosCoreContext : DbContext
    {
        public GastosCoreContext(DbContextOptions<GastosCoreContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
    }
}

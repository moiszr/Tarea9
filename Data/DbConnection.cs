using Microsoft.EntityFrameworkCore;

namespace Tarea9.Data
{
    public class DbConnection : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; } = default!;
        public DbSet<TipoSangre> TipoSangres { get; set; } = default!;
        public DbConnection(DbContextOptions<DbConnection> options) : base(options) { }
    }
}

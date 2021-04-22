using buffet.Models.Buffet.Cliente;
using Microsoft.EntityFrameworkCore;

namespace buffet.Data
{
    public class DatabaseContext : DbContext
    {

        public DbSet<ClienteEntity> Clientes { get; set; }
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        :base(options)
        {
            
        }
    }
}
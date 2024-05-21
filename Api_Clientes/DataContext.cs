using Microsoft.EntityFrameworkCore;

namespace Api_Clientes
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    }
}

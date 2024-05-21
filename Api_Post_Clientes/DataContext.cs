using Microsoft.EntityFrameworkCore;

namespace Api_Post_Clientes
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    }
}

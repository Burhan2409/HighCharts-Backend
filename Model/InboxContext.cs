using Microsoft.EntityFrameworkCore;

namespace MoviesAPIChart.Model
{
    public class InboxContext(DbContextOptions<InboxContext> options) : DbContext(options)
    {
        public DbSet<MoviesData> Movies { get; set; }

    }


}

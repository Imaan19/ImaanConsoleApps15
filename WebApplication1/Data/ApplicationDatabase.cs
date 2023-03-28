using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ApplicationDatabase : DbContext
    {
        public ApplicationDatabase(DbContextOptions<ApplicationDatabase>
            options) : base(options)
        {

        }
    }
}

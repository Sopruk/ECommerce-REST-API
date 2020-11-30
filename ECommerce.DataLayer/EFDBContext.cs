using ECommerce.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataLayer
{
    public class EFDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public EFDBContext(DbContextOptions options):base(options)
        {
        }
    }
}

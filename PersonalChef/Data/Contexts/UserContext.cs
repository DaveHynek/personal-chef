using Microsoft.EntityFrameworkCore;
using PersonalChef.Data.Models;

namespace PersonalChef.Data.Contexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}

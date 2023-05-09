using ApiUserMoi.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiUserMoi.Db
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=user_api");
        }
    }
}
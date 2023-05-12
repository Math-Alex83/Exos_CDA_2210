using APIBanque.Models;
using Microsoft.EntityFrameworkCore;

namespace APIBanque.Databases
{
    public class BankContext : DbContext
    {
        // création de l'accesseur 

        public DbSet<BankTransaction> BankTransactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) 
        {
            builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=tp_banks");
        }


        //  API FLUENT
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    /*base.OnModelCreating(builder);
        //    builder.Entity<BankTransaction>().HasIndex(b => b.Date).IsUnique();*/
        //}

    }
}
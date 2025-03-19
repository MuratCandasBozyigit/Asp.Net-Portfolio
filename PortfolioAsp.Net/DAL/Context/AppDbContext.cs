using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using PortfolioAsp.Net.DAL.Entities;

namespace PortfolioAsp.Net.DAL.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PortfolioDb;Trusted_Connection=True;");
            }
        }


        DbSet<About> About { get; set; }
        DbSet<Contact> Contact { get; set; }
        DbSet<Features> Features { get; set; }
        DbSet<Message> Message { get; set; }
        DbSet<Experience> Experience { get; set; }
        DbSet<Portfolio> Portfolio { get; set; }
        DbSet<Social> SocialMedia { get; set; }
        DbSet<Testimonials> Testimonials { get; set; }
        DbSet<Skills> Skills { get; set; }
    }
}

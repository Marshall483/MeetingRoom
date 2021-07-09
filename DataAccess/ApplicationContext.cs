using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    // create database
    public class ApplicationContext : DbContext
    {
        public DbSet<Booking> Booking { get; set; }
        public DbSet<MeetingRoom> MeetingRoom { get; set; }
        public DbSet<TechnicalSupport> TechnicalSupport { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Parcial02.Entities.Questions;
using Parcial02.Entities.Users;

namespace Parcial02.Context
{
    public class UcaClinicContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        
        public DbSet<Question> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=localhost;Database=UcaClinicdb;Trusted_Connection=True;");
        
    }
}
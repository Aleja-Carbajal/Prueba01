using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace Parcial02.Context
{
    public class UcaClinicContext : DbContext

    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=localhost\\MSSQLS15;Database=UcaClinicdb;Trusted_Connection=True;");
        
    }
}
global using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;

namespace Ath_Thoyyibah_BE.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(ValueStorage.connectionStringDev);
            optionsBuilder.UseMySql("Server=103.190.28.41,3306;Database=mamachef_dev;User ID=root;Password=P@sswordAdm1n", ServerVersion.AutoDetect("Server=103.190.28.41,3306;Database=mamachef_dev;User ID=root;Password=P@sswordAdm1n"));
        }

        public DbSet<ApplicationUser> Users { get; set; }
        
    }
}

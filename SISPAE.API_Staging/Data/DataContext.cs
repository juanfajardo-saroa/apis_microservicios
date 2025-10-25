using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SISPAE_API_Staging.WebAPI.Model;

namespace SISPAE_API_Staging.WebAPI.Data
{

    public class DataContext : IdentityDbContext<User>
    {
        private readonly DbContextOptions _options;
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            _options = options;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }

        //public DbSet<Company> Companies { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<iBPMS4US.Model.TS_TipoConstanteModelBase> TS_TipoConstanteModelBase { get; set; }
    }
}

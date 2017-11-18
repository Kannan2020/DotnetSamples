using System.Data.Entity;

namespace DI_BL_Model
{
    public class Context : DbContext
    {
        public Context() : base("name = EmployeeDBConnectionString"){}
        public DbSet<Employee> Employee { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

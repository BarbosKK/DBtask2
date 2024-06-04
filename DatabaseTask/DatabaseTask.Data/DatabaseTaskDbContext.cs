using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<VacationList> VacationList { get; set; }
        public DbSet<AccessLevel> AccessLevel { get; set; }
        public DbSet<Child> Child { get; set; }
        public DbSet<SickLeaveListID> SickLeaveListID { get; set; }
        public DbSet<HealthCheckList> HealthCheckLists { get; set; }
        public DbSet<LoanableItem> LoanableItem { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<PositionList> PositionList { get; set; }
    }
}

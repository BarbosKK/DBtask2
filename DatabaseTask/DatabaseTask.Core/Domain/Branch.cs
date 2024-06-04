using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }

        [ForeignKey("Company")]
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public TimeSpan OpeningHours { get; set; }
        public string Services { get; set; }
        public string ITInfrastructure { get; set; }
        public string SecurityMeasures { get; set; }
        public string ParkingAvailibility { get; set; }
        public Company Company { get; set; }
        public ICollection<Employee> Employees { get; set; }


    }
}

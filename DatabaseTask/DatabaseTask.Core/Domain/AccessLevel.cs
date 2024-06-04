using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class AccessLevel
    {
        [Key]
        public int AccessLevelID { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee Employees { get; set; }

    }
}

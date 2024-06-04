using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class SickLeaveListID
    {
        [Key]
        public int SickLeaveID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Employee Employee { get; set; }
    }
}

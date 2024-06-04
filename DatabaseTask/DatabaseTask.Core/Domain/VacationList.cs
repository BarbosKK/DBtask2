using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class VacationList
    {
        [Key]
        public int VacationID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Employee Employee { get; set; }

    }
}

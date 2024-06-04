using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class PositionList
    {
        [Key]
        public int PositionId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public string Position {  get; set; }
        public string Description {  get; set; }
        public Employee Employee { get; set; }

    }
}

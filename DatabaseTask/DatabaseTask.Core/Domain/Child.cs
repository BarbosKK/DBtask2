using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        [Key]
        public int ChildID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth{ get; set; }
        public Employee Employee { get; set; }

        
    }
}

using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class LoanableItem
    {
        [Key]
        public int ItemID { get; set; }
        public string Description { get; set; }
        public string? Availability { get; set; }
        
    }
}

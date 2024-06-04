using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        
        public string Industry { get; set; }
        public DateTime FoundedDate { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Website { get; set; }
        public string FinancialPerformance { get; set; }
        public string CompanyPolicies { get; set; }
        public ICollection<Branch> Branches { get; set; }

    }
}

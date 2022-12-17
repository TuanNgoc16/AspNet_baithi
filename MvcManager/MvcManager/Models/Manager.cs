using System.ComponentModel.DataAnnotations;

namespace MvcManager.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public string? EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public string? Department { get; set; }
        public int? Salary { get; set; }
    }
}

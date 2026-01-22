using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Employee
    {
        public int Id {get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public bool HomeOffice { get; set;  }

        public string PhoneNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        // Foreign Key to EmployeeInventoryRole
        public int EmployeeInventoryRoleId { get; set; }
        public EmployeeInventoryRole EmployeeInventoryRole { get; set; } = null!;

        // Foreign Key to Job
        public int JobId { get; set; }
        public Job Job { get; set; } = null!;

        // Foreign Key to Department
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

    }
}
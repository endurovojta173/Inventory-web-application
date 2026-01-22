namespace Inventory.API.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; } = string.Empty;

        // Foreign Key to HeadOfDepartment (Employee)
        public int? HeadOfDepartmentId { get; set; }
        public Employee? HeadOfDepartment { get; set; }

        // Navigation property for Employees in this Department
        public List<Employee>? Employees { get; set; }

    }
}
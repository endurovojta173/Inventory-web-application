using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Models
{
    [Index(nameof(RoleName), IsUnique = true)]
    public class EmployeeInventoryRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; } = string.Empty;
    }
}
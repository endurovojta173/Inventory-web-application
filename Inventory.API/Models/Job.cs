using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
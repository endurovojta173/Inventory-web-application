using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Models
{
    [Index(nameof(StatusName), IsUnique = true)]
    public class ItemStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; } = string.Empty;
    }
}
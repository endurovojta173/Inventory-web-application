using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Models
{
    [Index(nameof(ItemTypeName), IsUnique = true)]
    public class ItemType
    {
        public int Id { get; set; }
        public bool Borrowable { get; set; }
        public string ItemTypeName { get; set; } = string.Empty;
    }
}
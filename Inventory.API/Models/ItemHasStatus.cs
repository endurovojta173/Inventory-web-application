using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Models
{
    [Index(nameof(ItemId), nameof(StatusId), IsUnique = true)]
    public class ItemHasStatus
    {
        public int Id { get; set; }
        
        // Foreign Key to Item
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        // Foreign Key to Status
        public int StatusId { get; set; }
        public ItemStatus Status { get; set; } = null!;
    }
}
using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Models
{
    [Index(nameof(ManipulationTypeName), IsUnique = true)]
    public class ItemManipulationType
    {
        public int Id { get; set; }
        public string ManipulationTypeName { get; set; } = string.Empty;
    }
}
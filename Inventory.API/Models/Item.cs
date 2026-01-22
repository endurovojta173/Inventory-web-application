namespace Inventory.API.Models
{
    public class Item
    {
        public int Id {get; set; }

        public string ItemName { get; set; } = string.Empty;


        // Foreign Key to Owner (Employee)
        public int OwnerId { get; set; }
        public Employee? Owner { get; set; }

        // Foreign Key to CurrentHolder (Employee)
        public int CurrentHolderId { get; set; }
        public Employee? CurrentHolder { get; set; }

        // Foreign Key to ItemType
        public int ItemTypeId { get; set; }
        public ItemType ItemType { get; set; } = null!;

        // Foreign Key to Room
        public int RoomId { get; set; }
        public Room? Room { get; set; }
    }
}
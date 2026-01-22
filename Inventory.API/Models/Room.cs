namespace Inventory.API.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomName { get; set; } = string.Empty;

        // Foreign Key to Floor
        public int FloorId { get; set; }
        public Floor Floor { get; set; } = null!;

        // Foreign Key to RoomManager (Employee)
        public int RoomManagerId { get; set; }
        public Employee RoomManager { get; set; } = null!;
    }
}
namespace Inventory.API.Models
{
    public class Floor
    {
        public int Id { get; set; }
        public string FloorName { get; set; } = string.Empty;


        // Foreign Key to Building
        public int BuildingId { get; set; }
        public Building Building { get; set; } = null!;

        // Navigation property for Rooms on this Floor
        public List<Room> Rooms { get; set; } = new List<Room>();


    }
}